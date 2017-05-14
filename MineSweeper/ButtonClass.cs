using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
   public class ButtonClass
   {
       private int m_ButtonType;//Button所附属的种类  0代表此处有地雷， 1代表此处无地雷 但是附近有地雷，2代表此处什么标识有没有
       private int m_ButtonIndex;
       private int m_SurroundMineNums;
        public int ButtonType { get { return m_ButtonType; } }
        public int ButtonIndex { get { return m_ButtonIndex; } }

       public int SurroundMineNums
       {
           set
           {
               if (m_ButtonType==1)
               {
                   m_SurroundMineNums = value;
               }
           }
       }

       public string ButtonTag
       {
           get
           {
               if (m_ButtonType==0)
               {
                   return "*";
               }
               else if (m_ButtonType == 1)
               {
                   return m_SurroundMineNums.ToString();
               }
               else 
               {
                   return String.Empty;
               }
           }
       }

       public ButtonClass()
       {
           
       }
       public ButtonClass(int type,int index)
       {
           this.m_ButtonType = type;
           this.m_ButtonIndex = index;
       }
    }

  
}
