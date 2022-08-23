using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testroom18 : MonoBehaviour
{
    public Text d2maxtxt;
    bigdigital.Double2 d2max = new bigdigital.Double2();

    public Text d2mintxt;
    bigdigital.Double2 d2min = new bigdigital.Double2();

    public Text d2ctxt;
    bigdigital.Double2 d2c = new bigdigital.Double2();
    public InputField ifd2;

    public Text iimaxtxt;
    bigdigital.infint iimax = new bigdigital.infint();

    public Text iimintxt;
    bigdigital.infint iimin = new bigdigital.infint();

    public Text iictxt;
    bigdigital.infint iic = new bigdigital.infint();
    public InputField ifii;
    // Start is called before the first frame update
    void Start()
    {
        d2max = bigdigital.Double2.setmax(d2max);
        d2maxtxt.text = "max:" + bigdigital.Double2.getstring(d2max);

        d2min = bigdigital.Double2.setmin(d2min);
        d2mintxt.text = "min:" + bigdigital.Double2.getstring(d2min);

        d2ctxt.text = "crent:" + bigdigital.Double2.getstring(d2c);

        iimax = bigdigital.infint.setmax(iimax);
        iimaxtxt.text = "max:" + bigdigital.infint.getstring(iimax);

        iimin = bigdigital.infint.setmin(iimin);
        iimintxt.text = "min:" + bigdigital.infint.getstring(iimin);

        iictxt.text = "curent:" + bigdigital.infint.getstring(iic);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && ifii.text != "")
        {


            bigdigital.infint.addint(iic, int.Parse(ifii.text));
            iictxt.text = "curent:" + bigdigital.infint.getstring(iic);
        }
        if (Input.GetKeyDown(KeyCode.Return) && ifd2.text !="")
        {


            bigdigital.Double2.adddouble(d2c, double.Parse(ifd2.text));
            d2ctxt.text = "crent:" + bigdigital.Double2.getstring(d2c);
        }
    }
}
