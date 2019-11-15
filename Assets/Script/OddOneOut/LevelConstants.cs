
using UnityEngine;

public class LevelConstants
{
    // Start is called before the first frame update

    public static int NO_OF_CHAR_LEVEL_1 = 2;
    public static int NO_OF_CHAR_LEVEL_2 = 4;
    public static int NO_OF_CHAR_LEVEL_3 = 6;
    public static int NO_OF_CHAR_LEVEL_4 = 8;
    public static int NO_OF_CHAR_LEVEL_5 = 16;
    public static int WIDTH = 1920;
    public static int HEIGHT = 1080;
    public static int SIDE_MARGINS = 210;
    public static int AVATAR_MARGINGS = 400;


    public static Vector2[] getVectorArray(int level)
    {
        Vector2[] vArray = new Vector2[level];
        switch (level)
        {
            case 10:
                for(int i = 0; i < 5; i++)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        vArray[i+j] = new Vector2(WIDTH / 10 + j * WIDTH / 5, HEIGHT / 10 + i * HEIGHT / 5);    
                    }
                }break;
        }

        return vArray;
    }

    public static Vector2[] getRandomVectors(int numbers,float width)
    {
        Vector2[] arr = new Vector2[numbers];
        AVATAR_MARGINGS = (int)(width+20);
        
        for(int i = 0; i < numbers; i++)
        {
           
            int x= Random.Range(SIDE_MARGINS, WIDTH-SIDE_MARGINS);
            int y = Random.Range(SIDE_MARGINS, HEIGHT-SIDE_MARGINS-40);
            
            arr[i] = new Vector2(x, y);
            int j = 0;
            while(!findDistance(arr[i],arr,i))
            {
                if (j++ > 200)
                {
                    arr[i] = new Vector2(-100, -100);
                    break;
                }
                int b = Random.Range(SIDE_MARGINS, WIDTH - SIDE_MARGINS);
                int c = Random.Range(SIDE_MARGINS, HEIGHT - SIDE_MARGINS);
                arr[i] = new Vector2(b, c);
            }
        }

        return arr;
    }

    public static bool findDistance(Vector2 point, Vector2[] populatedIconPoints,int populatedIconSize)
    {
        for(int i = 0; i < populatedIconSize; i++)
        {
            float d = Vector2.Distance(point, populatedIconPoints[i]);
            if (d < AVATAR_MARGINGS) return false;
        }
       return true;
    }

    public static Vector2[] getVectors(int numberOfAvatars)
    {
        Vector2[] vArray = new Vector2[numberOfAvatars];
        switch (numberOfAvatars) {

            case 2:
                for (int i = 0; i < numberOfAvatars; i++)
                vArray[i] = new Vector2(WIDTH / 4 + WIDTH / 2 * i, HEIGHT / 2);
                break;
            case 4:
                vArray[0] = new Vector2(WIDTH / 4, HEIGHT / 4);
                vArray[1] = new Vector2(WIDTH / 4, 3*HEIGHT / 4);
                vArray[2] = new Vector2(3*WIDTH / 4, HEIGHT / 4);
                vArray[3] = new Vector2(3*WIDTH / 4, 3*HEIGHT / 4);
                break;
            case 6:
                vArray[0] = new Vector2(WIDTH / 4, HEIGHT / 4);
                vArray[1] = new Vector2(WIDTH / 4, 3*HEIGHT / 4);
                vArray[2] = new Vector2(WIDTH / 2, HEIGHT / 4);
                vArray[3] = new Vector2(WIDTH / 2, 3*HEIGHT / 4);
                vArray[4] = new Vector2(3*WIDTH / 4, HEIGHT / 4);
                vArray[5] = new Vector2(3*WIDTH / 4, 3*HEIGHT / 4);
                break;
            case 8:
                vArray[0] = new Vector2(WIDTH / 8, HEIGHT / 4);
                vArray[1] = new Vector2(WIDTH / 8, 3*HEIGHT / 4);
                vArray[2] = new Vector2(3*WIDTH / 8, HEIGHT / 4);
                vArray[3] = new Vector2(3*WIDTH / 8, 3*HEIGHT / 4);
                vArray[4] = new Vector2(5*WIDTH / 8, HEIGHT / 4);
                vArray[5] = new Vector2(5*WIDTH / 8, 3*HEIGHT / 4);
                vArray[6] = new Vector2(7*WIDTH / 8, HEIGHT / 4);
                vArray[7] = new Vector2(7*WIDTH / 8, 3*HEIGHT / 4);
                break;

        }


        return vArray;
    }






}
