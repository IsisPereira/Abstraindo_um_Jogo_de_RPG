namespace RpgJogo.Models
{
  public class Ajudador : Vencedor
  {
    public Ajudador()
    {
      Name = string.Empty;
      TypeVencedor = string.Empty;
    }

    public Ajudador(string Name, int Level, string TypeVencedor)
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
      return this.Name + " atacou com uma espada!";
    }

    public string Attack(string bonus, int power)
    {
      return this.Name + $" atacou com três {bonus}!";
    }
  }
}