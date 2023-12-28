namespace CestaBasica.Client
{
    public struct Item
    {
        public Item(int selectedQuantity, string selectedItem)
        {
            SelectedQuantity = selectedQuantity;
            SelectedItem = selectedItem;
        }

        public int SelectedQuantity { get; set; }
        public string SelectedItem { get; set; }
    }
}
