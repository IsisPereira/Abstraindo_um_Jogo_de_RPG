namespace RpgJogo.Models
{
  public class Disputador : Vencedor
  {
    public Disputador()
    {
      Name = string.Empty;
      TypeVencedor = string.Empty;
    }

    public Disputador(string Name, int Level, string TypeVencedor)
    {
      this.Name = Name;
      this.Level = Level;
      this.TypeVencedor = TypeVencedor;
    }

    public override string ToString()
    {
      return this.Name + " " + this.Level + " " + this.TypeVencedor;
    }

    public override string Attack()
    {
      return this.Name + " fez defesa!";
    }

    public string Attack(string bonus)
    {
      return this.Name + $" fez defesa com {bonus}!";
    }
  }
}