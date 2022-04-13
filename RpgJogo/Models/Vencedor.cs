namespace RpgJogo.Models
{
  public abstract class Vencedor
  {
    public string Name { get; set; }
    public int Level { get; set; }
    public string TypeVencedor { get; set; }
    public Vencedor()
    {
      Name = string.Empty;
      TypeVencedor = string.Empty;
    }
    public Vencedor(string Name, int Level, string TypeVencedor)
    {
      this.Name = Name;
      this.Level = Level;
      this.TypeVencedor = TypeVencedor;
    }

    public override string ToString()
    {
      return this.Name + " " + this.Level + " " + this.TypeVencedor;
    }

    public virtual string Attack()
    {
      return this.Name + " atacou com sua espada!";
    }
  }
}