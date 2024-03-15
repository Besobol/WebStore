using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Infrastructure.DataConstants
{
    public static class DataConstants
    {
        private const int pricePrecisionWhole = 6;
        private const int pricePrecisionDecimal = 2;

        public static class Book
        {
            public const int TitleMaxLength = 150;
            public const int TitleMinLength = 3;

            public const int SummeryMaxLength = 4000;
            public const int SummeryMinLength = 300;

            public const int PricePrecisionWhole = pricePrecisionWhole;
            public const int PricePrecisionDecimal = pricePrecisionDecimal;

            public const int ImgPathMaxLength = 500;
        }

        public static class UsedBook
        {
            public const int BookDetailsMaxLength = 1000;
            public const int BookDetailsMinLength = 10;

            public const int PricePrecisionWhole = pricePrecisionWhole;
            public const int PricePrecisionDecimal = pricePrecisionDecimal;
        }

        public static class Author
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 3;

            public const int DescriptionMaxLength = 1000;
            public const int DescriptionMinLength = 10;
        }

        public static class Publisher
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 2;

            public const int DescriptionMaxLength = 1000;
            public const int DescriptionMinLength = 10;
        }

        public static class Store 
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 2;

            public const int WebsiteMaxLength = 50;
        }

        public static class Genre
        {
            public const int NameMaxLength = 50;
        }

    }
}
