namespace Labs226_2021.Shop
{
    class Product
    {
        public string nameOfProduct;
        public double price;
        public int countOfProduct;
        public string manufacturer;

        public Product(string nameOfProduct, double price, int countOfProduct, string manufacturer)
        {
            this.nameOfProduct = nameOfProduct;
            this.price = price;
            this.countOfProduct = countOfProduct;
            this.manufacturer = manufacturer;
        }
    }
}
