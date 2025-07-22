using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TattooKitShop.Infrastructure.Data;

namespace TattooKitShop.Infrastructure.Data
{
    public static class DataConstants
    {
        public static class Product 
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 3;

            public const int DescriptionMaxLength = 1000;
            public const int DescriptionMinLength = 5;

            public const int BrandMaxLength = 20;
            public const int BrandMinLength = 3;

            public const string MaxPriceValue = "100000";
            public const string MinPriceValue = "0.10";

          
        }
        public static class ApplicationUser 
        {
            public const int UserNameMaxLength = 50;
            public const int UserNameMinLength = 3; 
        }

        public static class Category 
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 3;
        }
        public static class Order
        {
            public const string TotalAmountMaxValue = "1000000";
            public const string TotalAmountMinValue = "0";

            public const int ShippingAddressMaxLength = 50;
            public const int ShippingAddressMinLength = 10;

        }
        public static class Review 
        {
            public const int CommentMaxLength = 1000;
            public const int CommentMinLength = 3;
        }
        public static class Payment
        {
            public const string MaxPayment = "1000000";
            public const string MinPayment  = "0";

            public const int CardNumberMaxLength = 16;
            public const int CardNumberMinLength = 16;

            public const int SecurityNumberMaxLength = 3;
            public const int SecurityNumberMinLength = 3;

            public const string ExpireDateFormat = "MM/yy";
        }
        public enum OrderStatus
        {
            Pending = 0,
            Processed = 1,
            Shipped = 2,
            Delivered = 3,
            Canceled = 4,
            Completed = 5,
        }
        public enum PaymentStatus
        {
            Pending = 0,
            Completed = 1,
            Failed = 2,
            Canceled = 3
        }
        public enum PaymentMethod
        {
            CreditCard = 0,
            CashOnDelivery = 3
        }


    }
}

