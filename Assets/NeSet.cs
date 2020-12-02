using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeSet : MonoBehaviour {
    public En4Scr En;
    public ConGGScr Cs;
    public float Trmin = 0.25f, Trmax = 0.70f, Tr = 0;
    public float x1 = 0, y1 = 0;
    public float[] Kub = new float[8];
    public float[] W21 = new float[4];
    public float[,] W1 = new float[8, 9];
    public float[] N1 = new float[9];
    public float[,] W2 = new float[9, 4];
   // public float[] N2 = new float[4];
  //  public float[,] W3 = new float[4, 4];
   // public float[] N3 = new float[4];
   // public float[,] W4 = new float[4, 4];
   // public float[] N4 = new float[4];
   // public float[] Eps1 = new float[4];
    public float[] Vix = new float[4];
  //  public float[] Eps2 = new float[4];
    public float[] Eps3 = new float[8];
    public float[] Eps4 = new float[9];
    public float[] VoV = new float[4];
    public bool Yes,Tren=true;
    public float Osh,TimeDo=0.1f;
    public float E = 0.85f, a = 0.0f;
    public int Inter = 0;
    public int Z = 0;
    public int t = 1;
    public float xc, yc,sum=0f;
    public bool oncl = false ,ML, MR, TJ , TSh ,TrD=false;
    //public bool[,] Kub1 = new bool[4, 4];
    // Use this for initialization
    void Start () {
       OnRandom();

    }
    public void OnRandom()
    {

       
      
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                W1[i, j] = (Random.Range(1, 10))/10f;
                Eps4[j] = 0;
                N1[j] = 0;

            }

        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                W2[i, j] = (Random.Range(1, 10)) / 10f;
                Eps3[j] = 0;
                Vix[j] = 0;
            }

        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
              //  W3[i, j] = (Random.Range(-100, 100)) * 0.01f;
                //Eps2[j] = 0;
              //  N3[j] = 0;
            }

        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
             //  W4[i, j] = (Random.Range(-100, 100)) / 100f;
             //  Eps1[j] = 0;
         //   N4[j] = 0;

            }

        }


    }
    public void PolZn_1()
    {
        for (int i = 0; i < 9; i++)
        {

            N1[i] = 0;


        }
        for (int i = 0; i < 4; i++)
        {

            //Vix[i] = 0;

        }
        for (int i = 0; i < 4; i++)
        {

           // N3[i] = 0;

        }
        for (int i = 0; i < 4; i++)
        {

                 Vix[i] = 0;

        }





        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                N1[i] = N1[i] + W1[j, i] * Kub[j];
             
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
               // N2[i] = N2[i] + W2[j, i] * (1.0f / (1.0f + 1.0f / Mathf.Exp(N1[j])));
               
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
             //   N3[i] = N3[i] + W3[j, i] * (1.0f / (1.0f + 1.0f / Mathf.Exp(N2[j])));
               
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                        Vix[i] = Vix[i] + W2[j, i] * (1.0f / (1.0f + 1.0f / Mathf.Exp(N1[j])));

            }
        }
       
      for(int i=0;i<4;i++)
        {
            Vix[i]= ((1.0f / (1.0f + Mathf.Exp(-Vix[i]))));
        }
        Osh = (Mathf.Pow(Vix[0] - VoV[0], 2) + Mathf.Pow(Vix[1] - VoV[1], 2) + Mathf.Pow(Vix[2] - VoV[2], 2) + Mathf.Pow(Vix[3] - VoV[3], 2)) / 4f;
    }
/*              public void EpsR()
    {
        /*  if (Yes)
          {
              Eps1[0] = (0.95f - (1.0f / (1.0f + Mathf.Exp(-N4[0])))) * ((1.0f / (1.0f + 1.0f / Mathf.Exp(N4[0])) * (1.0f - (1.0f / (1.0f + 1.0f / Mathf.Exp(N4[0]))))));

          }
          else
          {
              Eps1[0] = (0.05f - (1.0f / (1.0f + Mathf.Exp(-N4[0])))) * ((1.0f / (1.0f + 1.0f / Mathf.Exp(N4[0])) * (1.0f - (1.0f / (1.0f + 1.0f / Mathf.Exp(N4[0]))))));
          }*/
      /*  for (int i = 0; i < 4; i++)
        {
            Eps2[i] = (VoV[i]-Vix[i])*(1-Vix[i])*Vix[i];
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Eps3[i] = Eps3[i] + ((1.0f / (1.0f + 1.0f / Mathf.Exp(N2[i])) * (1.0f - (1.0f / (1.0f + 1.0f / Mathf.Exp(N2[i])))))) * Eps2[j] * W3[i, j] + 0.3f;
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Eps3[i] = Eps3[i] + ((1.0f / (1.0f + 1.0f / Mathf.Exp(N1[i])) * (1.0f - (1.0f / (1.0f + 1.0f / Mathf.Exp(N2[i])))))) * Eps2[j] * W3[i, j] + 0.3f;
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Eps4[i] = Eps4[i] + ((1.0f / (1.0f + 1.0f / Mathf.Exp(N1[i])) * (1.0f - (1.0f / (1.0f + 1.0f / Mathf.Exp(N1[i])))))) * Eps3[j] * W2[i, j] + 0.3f;
            }
        }
    }
               private void timer3_()
    {

      
        
        PolZn_1();
      


       
        Inter++;
       

        x1 = Inter / 2f;
        y1 = Osh * 40;
        EpsR();
        CorW();


       

       
      
    }
                 public void CorW()
    {
        for (int i = 0; i < 4; i++)
        {

            for (int j = 0; j <4 ; j++)
            {
               //W4[i, j] = W4[i, j] + (E * Eps1[j] * (1.0f / (1.0f + 1.0f / Mathf.Exp(N3[i]))));
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                W3[i, j] = W3[i, j] + (E * Eps2[j] * (1.0f / (1.0f + 1.0f / Mathf.Exp(N2[i]))));
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                W2[i, j] = W2[i, j] + (E * Eps3[j] * (1.0f / (1.0f + 1.0f / Mathf.Exp(N1[i]))));
            }
        }
        for (int i = 0; i < 14; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                W1[i, j] = W1[i, j] + (E * Eps4[j] * (1.0f / (1.0f + 1.0f / Mathf.Exp(Kub[i]))));
            }
        }
    }
   */ public void REst()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
              
                Eps4[j] = 0;
              

            }

        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
               
                Eps3[j] = 0;
               
            }

        }
       /* for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
               
               // Eps2[j] = 0;
              
            }

        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
               
              // Eps1[j] = 0;
               

            }

        }*/


        for (int i = 0; i < 4; i++)
        {
            Eps3[i] = (VoV[i] - Vix[i]) * (1 - Vix[i]) * Vix[i] ;
        }
        for (int i = 0; i < 9; i++)
        {

            for (int j = 0; j < 4; j++)
            {
                W2[i, j] = W2[i, j] + (E * Eps3[j] * (1.0f / (1.0f + 1.0f / Mathf.Exp(N1[i]))));
            }
        }
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Eps4[i] = Eps4[i] + ((1.0f / (1.0f + 1.0f / Mathf.Exp(N1[i])) * (1.0f - (1.0f / (1.0f + 1.0f / Mathf.Exp(N1[i])))))) * Eps3[j] * W2[i, j] + a;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                W1[i, j] = W1[i, j] + (E * Eps4[j] * (1.0f / (1.0f + 1.0f / Mathf.Exp(Kub[i]))));
            }
        }
       /* for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
             //   Eps3[i] = Eps3[i] + ((1.0f / (1.0f + 1.0f / Mathf.Exp(N2[i])) * (1.0f - (1.0f / (1.0f + 1.0f / Mathf.Exp(N2[i])))))) * Eps2[j] * W3[i, j] + 0.3f;
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
              //  W2[i, j] = W2[i, j] + (E * Eps3[j] * (1.0f / (1.0f + 1.0f / Mathf.Exp(N1[i]))));
            }
        }*/
       /* for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Eps4[i] = Eps4[i] + ((1.0f / (1.0f + 1.0f / Mathf.Exp(N1[i])) * (1.0f - (1.0f / (1.0f + 1.0f / Mathf.Exp(N1[i])))))) * Eps3[j] * W2[i, j] + a;
            }
        }
        for (int i = 0; i < 14; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                W1[i, j] = W1[i, j] + (E * Eps4[j] * (1.0f / (1.0f + 1.0f / Mathf.Exp(Kub[i]))));
            }
        }*/

    }
    // Update is called once per frame
    void Update () {
      /*  Kub[1] = Cs.gameObject.transform.position.x*0.001f + 0.2f;
        Kub[2] = Cs.gameObject.transform.position.y / 1000f+0.2f;
        Kub[3] = (gameObject.transform.position.x- Cs.gameObject.transform.position.x)*0.001f+0.2f;
        Kub[0] = gameObject.transform.position.y / 1000f + 0.2f;
       */
      /*  VoV[0] = ML ? 0.8f : 0.2f;
        VoV[1] = MR ? 0.8f : 0.2f;
        VoV[2] = TSh ? 0.8f : 0.2f;
        VoV[3] = TJ ? 0.8f : 0.2f;*/


        if(Time.timeScale!=0)
        {
            PolZn_1();

        }
        for(int i=0;i<4;i++)
        {
            W21[i] = W2[i, i];
        }

        if (Vix[0]>0.7f)
        {
            En.ML=true;
            En.TrR = false;

        }
        else
        {
            En.ML = false;
        }
        if (Vix[1] > 0.7f)
        {
            En.MR = true;
            En.TrR = true;
        }
        else
        {
            En.MR = false;
        }
        if (Vix[2] > 0.7f)
        {
            En.TrSh = true;

        }
        else
        {
            En.TrSh = false;
        }
        if (Vix[3] > 0.7f)
        {
            En.Jump();

        }
        else
        {
            
        }


        if (Tren)
        {
            if (Time.timeScale != 0)
            {
                /* EpsR();
                 CorW();*/
                REst();

            }
            
           
           
          //  Time.timeScale = 0f;
           
            
                    
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
        }
        if(TrD)
        {
            TimeDo += 0.1f;
            Time.timeScale = 1f;
            TrD = false;
        }
        TimeDo -= Time.deltaTime;
        if(TimeDo<=0)
        {
            Time.timeScale = 0f;
        }

    }
    /* public partial class Form1 : Form
    {
       
       

    

      

        private void timer1_Tick(object sender, EventArgs e)
        {
       
           
      

   
    

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            oncl = false;
            Console.Write(oncl);
        }
        public float Trmin = 0.25f, Trmax = 0.70f,Tr=0;
        public float x1 = 0, y1 = 0;
        public float[] Kub = new float[240];
        public float[,] Kub2 = new float[240,4];
        public float[,] W1 = new float[240, 40];
        public float[] N1 = new float[40];
        public float[,] W2 = new float[40, 40];
        public float[] N2 = new float[40];
        public float[,] W3 = new float[40, 40];
        public float[] N3 = new float[40];
        public float[,] W4 = new float[40, 1];
        public float[] N4 = new float[1];
        public float[] Eps1 = new float[1];
        public float[] Eps2 = new float[40];
        public float[] Eps3 = new float[40];
        public float[] Eps4 = new float[40];
        public bool Yes;
        public float Osh;
        public float E = 0.85f, a = 0.0f;
        public int Inter = 0;

       
       
       

        

        private void button5_Click(object sender, EventArgs e)
        {
            int k = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Kub[k] = Kub1[i, j] ? 1 : 0f;
                    k++;
                }
            }
            PolZn_1();
           // textBox4.Text = (1 / (1 + Mathf.Exp(-N4[0]))).ToString();
            textBox4.Text = (1.0f / (1.0f + 1.0f / Mathf.Exp(N4[0]))).ToString();
            if ((1.0f / (1.0f + 1.0f / Mathf.Exp(N4[0]))) >= 0.70)
            {
                textBox3.Text = "da";
            }
            /*else if ((1 / (1 + Mathf.Exp(-N4[1]))) >= 0.70 && (1 / (1 + Mathf.Exp(-N4[0]))) <= 0.55)
            {
                textBox3.Text = "no";

            }
            else
            {
                textBox3.Text = textBox3.Text+"no2";

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
{


}

private void button6_Click(object sender, EventArgs e)
{
    for (int i = 0; i < 240; i++)
    {
        textBox7.Text = Kub[i].ToString();
    }
}

private void pictureBox1_Click(object sender, EventArgs e)
{

}

private void textBox5_TextChanged(object sender, EventArgs e)
{

}




private void button4_Click(object sender, EventArgs e)
{
    timer3.Enabled = true;
}

private void button8_Click(object sender, EventArgs e)
{
    timer3.Enabled = false;
}

private void timer2_Tick_1(object sender, EventArgs e)
{
    Pen myPen = new Pen(Color.Red, 2f);
    Graphics myGraphics = pictureBox2.CreateGraphics();
    PolZn_1();
    textBox4.Text = (1.0f / (1.0f + 1.0f / Mathf.Exp(N4[0]))).ToString();


    textBox1.Text = Osh.ToString();
    textBox2.Text = Inter.ToString();
    Inter++;
    myGraphics.DrawLine(myPen, ((float)x1), -((float)y1) + 40, Inter / 2f, -((float)Osh) * 40 + 40);

    x1 = Inter / 2f;
    y1 = Osh * 40;
    EpsR();
    CorW();


    textBox6.Text = W1[1, 15].ToString();
    textBox7.Text = W1[2, 13].ToString();

    textBox9.Text = Eps1[0].ToString();
}







public void S()
{


}
    }*/
}
