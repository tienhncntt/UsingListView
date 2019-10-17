using System;
using System.Collections.Generic;
using System.Text;

namespace UsingListview.Models
{
    public class FlowerType : List<Flower>
    {
        public string TypeName { get; set; }
        private FlowerType(string typeName)
        {
            TypeName = typeName;
        }
        public IList<FlowerType> FlowerTypes { get; set; }

        public FlowerType()
        {
            List<FlowerType> flowerTypeList = new List<FlowerType>
            {
                new FlowerType("Hoa cúc")
                {
                    new Flower
                    {
                        Name = "Đón xuân",
                        Description = "Hoa cúc các màu: trắng, vàng, cam",
                        Price = 50000,
                        Image = "img_SpringFlower.jpg"
                    },
                    new Flower
                    {
                        Name = "Hồn nhiên",
                        Description = "Hoa cúc các màu: vàng, cam, lá măng",
                        Price = 60000,
                        Image = "img_InnocentFlower.jpg"
                    },
                    new Flower
                    {
                        Name = "Tím thủy chung",
                        Description = "Hoa cúc tím",
                        Price = 45000,
                        Image = "img_VioletFlower.jpg"
                    }
                },

                new FlowerType("Hoa cuới")
                {
                     new Flower
                    {
                        Name = "Dây tơ hồng",
                        Description = "Hoa hồng màu hồng đậm, hoa hồng xanh, các loại lá...",
                        Price = 50000,
                        Image = "img_Rose.jpg"
                    },
                    new Flower
                    {
                        Name = "Cầu thủy tinh",
                        Description = "Hoa hồng và hoa thủy tiên tầng",
                        Price = 60000,
                        Image = "img_WhiteRose.jpg"
                    },
                    new Flower
                    {
                        Name = "Duyên thầm",
                        Description = "Hoa cúc trắng, baby, lá măng",
                        Price = 45000,
                        Image = ""
                    }
                }
            };
            FlowerTypes = flowerTypeList;
        }
    }
}
