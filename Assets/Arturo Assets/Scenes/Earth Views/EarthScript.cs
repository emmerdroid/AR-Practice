using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthScript : MonoBehaviour
{

    Material mMaterial;
    MeshRenderer mMeshRenderer;

    [SerializeField]
    private Text _weather;
    string forecast;


    float[] mPoints;
    int mHitCount;
    int counter;
    float mDelay;
    string continent;

    private bool toggle = false;
    private bool isPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        mDelay = 1;

        mMeshRenderer = GetComponent<MeshRenderer>();
        mMaterial = mMeshRenderer.material;

        mPoints = new float[75 * 3];
    }


    public void weather()
    {
        _weather.text = forecast;
    }

    public void Default()
    {
        toggle = !toggle;
        counter = 0;
    }

    public void Europe()
    {
        toggle = !toggle;
        continent = "Europe";
    }

    public void ToggleSwitch()
    {
        if (isPlaying)
        {
            isPlaying = false;
        }
        else
        {
            isPlaying = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
            if (isPlaying)
            {
                if (continent == "Europe")
                {

                    mDelay -= Time.deltaTime;
                    if (mDelay <= 0)
                    {
                        GameObject go = Instantiate(Resources.Load<GameObject>("Projectile Europe"));
                        go.transform.position = new Vector3(460f, Random.Range(931f, 936f), Random.Range(-5f, 15f));
                        mDelay = .5f;
                        counter++;

                    }
                }
                else
                {
                    mDelay -= Time.deltaTime;
                    if (mDelay <= 0)
                    {
                        GameObject go = Instantiate(Resources.Load<GameObject>("Projectile"));  //Los Angeles
                        GameObject go2 = Instantiate(Resources.Load<GameObject>("Projectile")); //Las Vegas
                        GameObject go3 = Instantiate(Resources.Load<GameObject>("Projectile")); //Seattle
                        GameObject go4 = Instantiate(Resources.Load<GameObject>("Projectile")); //Denver
                        GameObject go5 = Instantiate(Resources.Load<GameObject>("Projectile")); //Dallas
                    //    GameObject go6 = Instantiate(Resources.Load<GameObject>("Projectile")); //Atlanta
                    //    GameObject go7 = Instantiate(Resources.Load<GameObject>("Projectile")); //Chicago
                    //  GameObject go8 = Instantiate(Resources.Load<GameObject>("Projectile")); //New York


                        go.transform.position = new Vector3(Random.Range(375f, 376f), Random.Range(891f, 893f), -40);  //Los Angeles

                        go2.transform.position = new Vector3(Random.Range(380f, 382f), Random.Range(897f, 899f), -40); //Las Vegas

                        go3.transform.position = new Vector3(Random.Range(367f, 369f), Random.Range(930f, 932f), -40); //Seattle

                        go4.transform.position = new Vector3(Random.Range(398f, 400f), Random.Range(907f, 908f), -40); //Denver

                        go5.transform.position = new Vector3(Random.Range(411f, 413f), Random.Range(888f, 890f), -40); //Dallas

                     // go6.transform.position = new Vector3(Random.Range(385f, 388f), Random.Range(899f, 902f), -40); //Atlanta

                     // go7.transform.position = new Vector3(Random.Range(380f, 383f), Random.Range(894f, 898f), -40);

                     // go8.transform.position = new Vector3(Random.Range(385f, 388f), Random.Range(899f, 902f), -40);


                        mDelay = .5f;
                        counter++;
                    }
                }
                Debug.Log(counter);
                if (counter >= 14)
                {
                    toggle = false;
                    isPlaying = false;
                    counter = 0;
                }
           }
    }

    private IEnumerator Waiting()
    {
        yield return new WaitForSeconds(3);
    }


    private void OnCollisionEnter(Collision collision)
    {
        foreach(ContactPoint cp in collision.contacts)
        {
            Debug.Log("Contact with object " + cp.otherCollider.gameObject.name);


            Ray ray = new Ray(cp.point - cp.normal, cp.normal);
            RaycastHit hit;

            bool hitit = Physics.Raycast(ray, out hit, 10f, LayerMask.GetMask("HeatMapLayer"));

            if(hitit)
            {
                Debug.Log("Hit Object " + hit.collider.gameObject.name);
                Debug.Log("Hit Texture coordinates = " + hit.textureCoord.x + "," + hit.textureCoord.y);
                addHitPoint(hit.textureCoord.x*300-75, hit.textureCoord.y*300-75);

            }

            Destroy(cp.otherCollider.gameObject);
           
        }
        enabled = false;
    }

    public void addHitPoint(float xp, float yp)
    {
        mPoints[mHitCount * 3] = xp;
        mPoints[mHitCount * 3 + 1] = yp;
        mPoints[mHitCount * 3 + 2] = 1;

        mHitCount++;
        mHitCount %= 75;

        mMaterial.SetFloatArray("_Hits", mPoints);
        mMaterial.SetInt("_HitCount", mHitCount);

    }
}
