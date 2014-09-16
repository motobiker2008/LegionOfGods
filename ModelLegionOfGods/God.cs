using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ModelLegionOfGods
{
    public class God
    {
        private Image image;

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        private String title;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        private String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public God(String title, String pathImage, String description)
        {
            this.title = title;
            this.description = description;
            this.image = Image.FromFile(pathImage);
        }

        public God(String title, Image image, String description)
        {
            this.title = title;
            this.description = description;
            this.image = image;
        }
    }
}
