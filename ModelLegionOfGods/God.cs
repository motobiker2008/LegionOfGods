using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ModelLegionOfGods
{
    /// <summary>
    /// Класс God
    /// Хранит информацию о боге
    /// </summary>
    public class God
    {
        private Image image;
        private String title;
        private String description;

        /// <summary>
        /// Свойство содержащее изображение бога
        ///</summary>
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }
        /// <summary>
        /// Свойство содержащее имя бога
        ///</summary>
        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        /// <summary>
        /// Свойство содержащее описание бога
        ///</summary>
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
