using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqualPlayer
{
    public class Player
    {
        public PlayerClass PClass {get; }
        public string Name {get ;}
        public Player (PlayerClass pClass, string name )
        {
            PClass = pClass ;
            Name = name ;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //since we just want it to always insert if is equal..?
            return false;
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // I HAVE NO IDEA, THIS MAKES NO SENESE AT ALLLLLLL
            throw new System.NotImplementedException();
            return base.GetHashCode();
        }

    }
}