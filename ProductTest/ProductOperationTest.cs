using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ProductTest
{ 
    [TestFixture]
    public class ProductOperationTest
    {
        private ProductManager _productManager;
        private EfProductDal _efProductDal;



        [SetUp]


        public void Setup()
        {

            _efProductDal = new EfProductDal();
            _productManager = new ProductManager( _efProductDal);  



        }








        [Test]
        public void Product_ListedAllProducts_GetAll()
        {
            IProductService productService = new ProductManager(new EfProductDal());

            var products = _productManager.GetAll();


            Assert.IsNotNull( products,"Ürünler null olmamalýdýr." );
           


        }
    }
}