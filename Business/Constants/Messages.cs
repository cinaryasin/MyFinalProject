using Entities.ConCrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "ürünler listelendi";
        public static string MaintenanceTime = "Sistem bakımda ";
        public static string ProductCountOfCategoryError = "kategoride En fazla 10 ürün olabilir";
        public  static string ProductNameAlreadyExists = "Bu ürün isminden zaten 1 tane daha var";
        public static string CategoryLimitExceded = "Kategory limiti aşıldığı için yeni ürün eklenemez ";
    }
}
