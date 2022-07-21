
namespace PresidentVote.Entities {
    internal class Candidates {

        public string Name { get; set; }
        public int NumberOfVotes { get; set; }

        public Candidates(string candidateName) {
            Name = candidateName;
            NumberOfVotes = 0;
        }


        public override string ToString() {
            return "Candidato: " + Name + ", votos: " + NumberOfVotes;
        }
    }
}
