using Microsoft.VisualBasic;

namespace Roman_Numerals;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RomanConverter(1954));
    }

    public static string RomanConverter(int n){
        List<char> conversion = [];
        while(n>0){
            Console.WriteLine(n);
            switch (n)
            {                
                case >=1000:
                    conversion.Add('M');
                    n-=1000;
                    break;
                case >=900: //Edgecase
                    conversion.Add('C');
                    conversion.Add('M');
                    n-=900;
                    break;
                case >=500:   
                    conversion.Add('D');
                    n-=500;
                    break;
                case >=400:
                    conversion.Add('C');
                    conversion.Add('D');
                    n-=400;
                    break;
                case >=100:
                    conversion.Add('C');
                    n-= 100;
                    break;
                case >=90:
                    conversion.Add('X');
                    conversion.Add('C');
                    n-=90;
                    break;
                case >=50:
                    conversion.Add('L');
                    n-=50;
                    break;
                case >=40: 
                    conversion.Add('X');
                    conversion.Add('L');
                    n-=40;
                    break;
                case >=10:
                    conversion.Add('X');
                    n-=10;
                    break;
                case >=9:
                    conversion.Add('I');
                    conversion.Add('X');
                    n-=9;
                    break;
                case >=5:
                    conversion.Add('V');
                    n-=5;
                    break;
                case >=4:
                    conversion.Add('I');
                    conversion.Add('V');
                    n-=4;
                    break;
                case >=1:
                    conversion.Add('I');
                    n-=1;
                    break;

                default:
                    break;
            }         
        }
        return new string(conversion.ToArray());
    }
}
