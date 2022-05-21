using System.Text.Json;

namespace DP_HWS2_Proxy_Mediator
{
    public class Citizen
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMale { get; set; }

        public string Address { get; set; }
        public bool IsMarriage { get; set; }
        
        public List<Citizen> Children = new List<Citizen>();
        public DateTime PassportCreateDate { get; set; }

        public Citizen(string firstName, string lastName, int id, DateTime birthDate, bool isMale = true)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            BirthDate = birthDate;
            IsMale = isMale;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}