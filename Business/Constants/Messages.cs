using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static olursa new lemek zorunda kalmayız.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string MaintananceTime = "Bakım zamanı.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu ada sahip ürün zaten mevcut.";
        public static string CategoryLimitExceded = "Kategori limitine ulaşıldığı için ürün eklenemedi.";
    }
}
