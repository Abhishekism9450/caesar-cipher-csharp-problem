using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            char[] cch ={'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'} ;
            char[] ch= {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            string str="";
            for(int i=0;i<text.Length;i++){
                if (!char.IsLetter(text[i])) 
                {
                    str += text[i];
                } else if(text[i]>=65 && text[i]<=90){
                    var vall =(((Array.IndexOf(cch,text[i]))+shiftKey)%26);
                    str= str+ cch[vall];
                }
                else if(text[i]>=97 && text[i]<=122){
                    var val =(((Array.IndexOf(ch,text[i]))+shiftKey)%26);
                    str= str+ ch[val];
                }
                else if(text[i]>=48 && text[i]<=57){
                    str=str+text[i];
                }
                
                
            }
            return str;
            throw new NotImplementedException("You need to implement this function.");
        }
        public static void Main(string[] args){
            
        }
    }
}
