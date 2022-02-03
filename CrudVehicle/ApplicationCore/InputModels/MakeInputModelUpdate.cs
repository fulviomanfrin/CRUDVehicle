namespace ApplicationCore.InputModels
{
    internal class MakeInputModelUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MakeInputModelUpdate(int id, string name)
        {
            Id = id;
            Name = name;
            
        }

    }
}
