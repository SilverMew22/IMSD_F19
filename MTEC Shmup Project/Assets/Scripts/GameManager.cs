// These are the libraries this script uses

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{
    

    //This is used to make GameManager a singleton to have it be easily accessible from all other scripts
    //This is doable because I know in advance there should only ever be a single GameManager in the scene
    public static GameManager inst;

    //Using headers to label variable groups in the Inspector
    [Header("ENEMY SETTINGS")]

    //These are the variables that will set the enemy parameters. We are setting them in the GameManager because there is... 
    //...no enemy in the scene by default. They get created at runtime from the GameManager script (see SpawnEnemy() below)
    public float enemyMoveSpeed;
    public float enemyMoveWaveFrequency;
    public float enemyMoveWaveAmplitude;
    [Range(1,10)]public int enemyHealth;
    public float enemyDodgeAmount; 
    public float enemyBulletDetectionRadius;
    public float enemyBulletDetectionDistance;
    public float initialEnemySpawnDelay;
    public float timeBetweenEnemySpawns;
   
     [Range(1,10)] public int maxEnemysOnScreen;
    public float enemyBulletSpeed;
    public float enemyFireDelay;
    [Range(1,15)]public int maxEnemyBulletsOnScreen;

    [Header("CAMERA SETTINGS")]
    [Range (0,1)] public float cameraShakePower;

    [Header("UI SETTINGS")]
    public bool enableUI;
    public Gradient healthBarGradient;
    public Color textColor;

    Text[] gameTexts;
    Image healthBar;
    float targetAmount;

    int score;
    int highScore;

    [Header("OTHER SETTINGS")]
    public bool enableAudio;
    public bool enableParticles;

    [HideInInspector]
    public GameObject enemyBulletHolder;
    [HideInInspector]
    public GameObject bulletHolder;

    Text scoreText;
    Text highScoreText;


    GameObject enemyPrefab;
    GameObject enemyBulletPrefab;

    GameObject explosionPrefab;

    ParticleSystem stars;

    float xPos = 9.5f;    
    float t;

    bool gameOver;

    // Awake runs before Start() so use it to run code that initlaizes variables or sets game states before the game Starts.
    // Most of the time you can run things in start, but sometimes it is important that the code is run before the Start method runs.
    private void Awake() {
        //Here we're setting the GameManager singleton to this instance of the class. And making sure there isn't another one
        //If there is we destroy it.
        if (inst != null) {
            Destroy(gameObject);
        } else {
            inst = this;
        }

        enemyBulletHolder = new GameObject("EnemyBulletHolder");
        bulletHolder = new GameObject("BulletHolder");

        //When using Unity UI, all the UI elemeents must be children of a Canvas GameObject. Here we are getting a reference to the canvas object
        var canvas = GameObject.Find("Canvas");
        if (canvas != null){
            // then we are looking into the Canvas and getting a reference to the healthbar image and putting the texts in the array we initilized above (line 40)
            gameTexts = canvas.GetComponentsInChildren<Text>();
            healthBar = canvas.GetComponentInChildren<Image>();
        }
    }

    // Start is always called once at the start of the game, or when the object containing this script first becomes active. 
    private void Start() {
        t = initialEnemySpawnDelay;

        //In Unity, when you put a Prefab in a folder called "Assets/Resources", you can then use a Resources.Load method that loads the prefab at runtime.
        //This way you don't need to have the prefab in the scene when the game starts. 
        enemyPrefab = Resources.Load<GameObject>("Enemy") as GameObject;
        enemyBulletPrefab = Resources.Load<GameObject>("EnemyBullet") as GameObject;
        explosionPrefab = Resources.Load<GameObject>("ShipExplosion") as GameObject;

        //Here we get a reference to the Star particle system we have parented to the Camera GameObject in the hierarchy.
        // We only set it as Active if enable particles is set to true;
        stars = Camera.main.gameObject.GetComponentInChildren<ParticleSystem>();
        stars.gameObject.SetActive(enableParticles);

        //We set the camera shake power on the camera to whatever value we set in the inspector
        CameraShake.inst.shakeAmount = cameraShakePower;

        if (enableUI){
            // This is the Restart text, we are disabling it when the game starts
            targetAmount = healthBar.fillAmount;
            gameTexts[2].gameObject.SetActive(false);

            foreach (Text text in gameTexts) {
                text.color = textColor;
            }
            //Persistent Data has to be written to and fetched from the PlayerPrefs class, which writes the data in your filesystem
            //This way the Highscore remains and can be fetched even when you exit the game.
            highScore = PlayerPrefs.GetInt("highscore", highScore);
        } else {
            if (gameTexts != null && healthBar != null ){
                foreach (Text text in gameTexts){
                    text.gameObject.SetActive(false);
                }

                healthBar.gameObject.SetActive(false);
            }
        }
    }

    // In Unity, Update() is a function that runs every frame. 
    private void Update() {

        // This is a basic timer for spawning enemies
        //It uses the timeBetweenEnemySpawns value to space Spawning apart. We call SpawnEnemy() to do the actual spawning
        if (t > 0) {
            t -= Time.deltaTime;
        } else {
            SpawnEnemy();
            t = timeBetweenEnemySpawns;
        }

        //If we reach a Game Over state, Activate the restart text and reload the scene when the appropriate button is pressed
        if (gameOver) {

            if (enableUI){
                gameTexts[2].gameObject.SetActive(true);
            }


            if (Input.GetKeyDown(KeyCode.Return)) {
                SceneManager.LoadScene(0); 
            }
        }

        // Here we handle the UI elements. 
        // DisplayScores() is a function we made to handle the Score text
        if (enableUI) {
            DisplayScores();

            // Here we control the health bar movement, lerping it smoothly when the player takes damage
            float s = 5;
            healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, targetAmount, s * Time.deltaTime);

            // This controls the color of the bar. We take our custom Color Gradient and use the fillAmount property to tell use where in the...
            //...color gradient to take the color from (fillAmount is a value between 0-1). 
            healthBar.color = healthBarGradient.Evaluate(healthBar.fillAmount);
        }
    }

    // Here we spawn an enemy in a random position along the Y axis
    // We then access all the variables of the enemy, setting them to the values we specificed in the Inspector.  
    void SpawnEnemy() {
       // Vector2 pos = new Vector2(xPos, Random.Range(-3.5f, 3.4f));
        Vector2 pos = new Vector2(Random.Range(-3.5f, 3.4f),xPos);
        //GameObject enemy = Instantiate(enemyPrefab, pos, enemyPrefab.transform.localRotation);
        GameObject enemy = Instantiate(enemyPrefab, pos, enemyPrefab.transform.localRotation);

        var es = enemy.GetComponent<EnemyScript>();
        es.moveSpeed = enemyMoveSpeed;
        es.moveWaveFreq = enemyMoveWaveFrequency;
        es.moveWaveAmp = enemyMoveWaveAmplitude;
        es.health = enemyHealth;
        es.dodge = enemyDodgeAmount;
        es.bulletDetectionRad = enemyBulletDetectionRadius;
        es.bulletDetectionDist = enemyBulletDetectionDistance;
        es.bulletHolder = enemyBulletHolder.transform;
        es.bulletPrefab = enemyBulletPrefab;
        es.bulletSpeed = enemyBulletSpeed;
        es.maxBulletsOnScreen = maxEnemyBulletsOnScreen;
        es.fireDelay = enemyFireDelay;
    }

    public void IncreaseScore() {
        score += 1;
    }

    public void GameOver() {
        gameOver = true;
    }

    void DisplayScores() {
        if (score > highScore) {
            highScore = score;
            PlayerPrefs.SetInt("highscore", highScore);
        }

        gameTexts[0].text = "Score  " + score.ToString("000");
        gameTexts[1].text = "Best  " + highScore.ToString("000");
    }

    //This gets called from PlayerScript, when the player takes damage
    public void SetNewFillAmount(int fill, int maxFill) {
        targetAmount = (float)fill / (float)maxFill;
    }

    //A public method we can call from anywhere to trigger an explosion at a specific spot
    public void TriggerExplosion(Vector2 pos, float shake) {

        //Returns and ends the code execution if Enable Particles is not set to true
        if (!enableParticles) return;

        GameObject e = Instantiate(explosionPrefab, pos, Quaternion.identity);
        CameraShake.inst.shakeDuration = shake;
        SoundManager.inst.PlaySoundAtPosition(pos, 0);

        //See Comment below
        StartCoroutine(RemoveExplosionObject(e));
    }

    // In Unity, IEnumerators are used in Coroutines. 
    // We can use them to run a certain behavior over time even outside of Update().
    // In this case we're telling the game to wait 2.5 secs before executing the code below it.
    // We want to remove the ParticleSystem object we instantiated but we want to make sure it is done playing before we do this, hence the wait time.
    // Ideally we would get the exact lifetime of the particle system instead of putting in an arbitrary value, but this is fine for our current purposes 
    IEnumerator RemoveExplosionObject(GameObject o) {
        yield return new WaitForSeconds(2.5f);
        Destroy(o);
    }
}
