﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crisis.Charset
{
    class Cyrillic : Default
    {
        public List<string> ListcyrillicLowerCase(string charsetName)
        {
            if (charsetName == "lcyrillic")
            {
                //lcyrillic
                charsetSelecting = Cyrillic.ToList();
                
            }
            else if (charsetName == "lcyrillic-space")
            {
                // lcyrillic-space
                charsetSelecting = Cyrillic.Concat(Space).ToList();                
            }
            else if (charsetName == "lcyrillic-numeric")
            {
                // lcyrillic-numeric
                charsetSelecting = Cyrillic.Concat(Numeric).ToList();                
            }
            else if (charsetName == "lcyrillic-numeric-space")
            {
                //lcyrillic - numeric - space
                charsetSelecting = Cyrillic.Concat(Numeric).Concat(Space).ToList();                
            }
            else if (charsetName == "lcyrillic-numeric-symbol14")
            {
                //lcyrillic-numeric-symbol14
                charsetSelecting = Cyrillic.Concat(Numeric).Concat(Symbols14).ToList();                
            }
            else if (charsetName == "lcyrillic-numeric-symbol14-space")
            {
                // lcyrillic-numeric-symbol14-space
                charsetSelecting = Cyrillic.Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();               
            }
            else if (charsetName == "lcyrillic-numeric-all")
            {
                //lcyrillic-numeric-all
                charsetSelecting = Cyrillic.Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();              
            }
            else if (charsetName == "lcyrillic-numeric-all-space")
            {
                //lcyrillic-numeric-all-space
                charsetSelecting = Cyrillic.Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();
            }

            return charsetSelecting;
        }

        public List<string> ListCyrillicUpperCase(string charsetName)
        {
            if (charsetName == "ucyrillic")
            {
                //ucyrillique
                charsetSelecting = Cyrillic.ConvertAll(item => item.ToUpper()).ToList();            
            }
            else if (charsetName == "ucyrillic-space")
            {
                //uacyrillique-space
                charsetSelecting = Cyrillic.ConvertAll(item => item.ToUpper()).Concat(Space).ToList();                
            }
            else if (charsetName == "ucyrillic-numeric")
            {
                //ucyrillique-numeric
                charsetSelecting = Cyrillic.ConvertAll(item => item.ToUpper()).Concat(Numeric).ToList();                
            }
            else if (charsetName == "ucyrillic-numeric-space")
            {
                //ucyrillique_numeric_space
                charsetSelecting = Cyrillic.ConvertAll(item => item.ToUpper()).Concat(Numeric).Concat(Space).ToList();                
            }
            else if (charsetName == "ucyrillic-numeric-symbol14")
            {
                //ucyrillic-numeric-symbol14
                charsetSelecting = Cyrillic.ConvertAll(item => item.ToUpper()).Concat(Numeric).Concat(Symbols14).ToList();                
            }
            else if (charsetName == "ucyrillic-numeric-symbol14-space")
            {
                //ucyrillic-numeric-symbol14-space
                charsetSelecting = Cyrillic.ConvertAll(item => item.ToUpper()).Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();
            }
            else if (charsetName == "ucyrillic-numeric-all")
            {
                //ucyrillique-numeric-all
                charsetSelecting = Cyrillic.ConvertAll(item => item.ToUpper()).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();                
            }
            else if (charsetName == "ucyrillic-numeric-all-space")
            {
                //ucyrillique-numeric-all-space
                charsetSelecting = Cyrillic.ConvertAll(item => item.ToUpper()).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();                
            }

            return charsetSelecting;
        }

        public List<string> ListMixCyrillic(string charsetName)
        {

            if (charsetName == "mixcyrillic")
            {
                //mixcyrillic
                charsetSelecting = Cyrillic.Concat(Cyrillic.ConvertAll(item => item.ToUpper())).ToList();
                
            }
            else if (charsetName == "mixcyrillic-space")
            {
                //mixcyrillic-space
                charsetSelecting = Cyrillic.Concat(Cyrillic.ConvertAll(item => item.ToUpper())).Concat(Space).ToList();
               
            }
            else if (charsetName == "mixcyrillic-numeric")
            {
                //mixcyrillic-numeric
                charsetSelecting = Cyrillic.Concat(Cyrillic.ConvertAll(item => item.ToUpper())).Concat(Numeric).ToList();

            }
            else if (charsetName == "mixcyrillic-numeric-space")
            {
                //mixcyrillic-numeric-space
                charsetSelecting = Cyrillic.Concat(Cyrillic.ConvertAll(item => item.ToUpper())).Concat(Numeric).Concat(Space).ToList();
                
            }
            else if (charsetName == "mixcyrillic-numeric-symbol14")
            {
                //mixcyrillic-numeric-symbol14
                charsetSelecting = Cyrillic.Concat(Cyrillic.ConvertAll(item => item.ToUpper())).Concat(Numeric).Concat(Symbols14).ToList();
                
            }
            else if (charsetName == "mixcyrillic-numeric-symbol14-space")
            {
                //mixcyrillic-numeric-symbol14-space
                charsetSelecting = Cyrillic.Concat(Cyrillic.ConvertAll(item => item.ToUpper())).Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();
                
            }
            else if (charsetName == "mixcyrillic-numeric-all")
            {
                //mixcyrillic-numeric-all
                charsetSelecting = Cyrillic.Concat(Cyrillic.ConvertAll(item => item.ToUpper())).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();
            }
            else if (charsetName == "mixcyrillic-numeric-all-space")
            {
                //mixcyrillic-numeric-all-space
                charsetSelecting = Cyrillic.Concat(Cyrillic.ConvertAll(item => item.ToUpper())).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();
            }
            
            return charsetSelecting;
        }
    }
}
