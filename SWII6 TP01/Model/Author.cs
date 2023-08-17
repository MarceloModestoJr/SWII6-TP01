// Marcelo Modesto de Lima Junior CB3015823
// Bruna Helena Silva Santos CB3016111

namespace TP01.Models
{
    public class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }


        public Author(string name, string email, char gender)
        {
            this.Name = name;
            this.Email = email;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return $"Author[name={this.Name}, email={this.Email}, gender={this.Gender}]";
        }
    }
}
