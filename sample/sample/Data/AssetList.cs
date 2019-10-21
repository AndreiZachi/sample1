using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace sample.Data
{
    public class AssetList : ObservableCollection<Assets>
    {
        public AssetList()
        {
            Add(new Assets { Img = "imune.jpg" , Link = "http://www.google.com"} );
            Add(new Assets { Img = "serenity_tape_2.jpg", Link = "http://www.google.com" } );
            Add(new Assets { Img = "thor_eight.jpg", Link = "http://www.google.com" } );
            Add(new Assets { Img = "thor_one_six.jpg", Link = "http://www.google.com" } );
            Add(new Assets { Img = "thor_three_six.jpg", Link = "http://www.google.com" } );
            Add(new Assets { Img = "wknight_three_six.jpg", Link = "http://www.google.com" } );
            Add(new Assets { Img = "imune.jpg", Link = "http://www.google.com" });
            Add(new Assets { Img = "serenity_tape_2.jpg", Link = "http://www.google.com" });
            Add(new Assets { Img = "thor_eight.jpg", Link = "http://www.google.com" });
            Add(new Assets { Img = "thor_one_six.jpg", Link = "http://www.google.com" });
            Add(new Assets { Img = "thor_three_six.jpg", Link = "http://www.google.com" });
            Add(new Assets { Img = "wknight_three_six.jpg", Link = "http://www.google.com" });

        }


    }
}
