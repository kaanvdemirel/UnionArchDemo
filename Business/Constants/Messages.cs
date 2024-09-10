using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {

        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi en az 2 karakter olmalıdır.";
        public static string MaintenanceTime = "Bakım Zamanı";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductDeleted = "Ürün Silindi.";
        public static string ProductUpdated = "Ürün Güncellendi.";
        public static string ProductNotFound = "Ürün Bulunamadı";
        internal static string CustomerAdded = "Müşteri Eklendi.";
        internal static string CustomerDeleted = "Müşteri Silindi.";
        internal static string CustomerUpdated = "Müşteri Güncellendi.";
        internal static string CustomerListed = "Müşteriler Listelendi.";
        internal static string OrderAdded = "Ürün Eklendi.";
        internal static string OrderDeleted = "Ürün Silindi.";
        internal static string OrderListed = "Ürünler  Listelendi.";
        internal static string OrderUpdated = "Ürün Güncellendi.";
    }
}
