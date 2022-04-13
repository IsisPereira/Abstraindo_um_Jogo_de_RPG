namespace RpgJogo.Models
{
  public class Infame : Vencedor
  {
    public int HP { get; set; }
    public bool Life { get; set; }

    public Infame()
    {
      Name = string.Empty;
      TypeVencedor = string.Empty;
    }
    public Infame(string Name, int Level, string TypeVencedor)
    {
      this.Name = Name;
      this.Level = Level;
      this.TypeVencedor = TypeVencedor;
      this.HP = 100;
      this.Life = true;
    }

    public override string ToString()
    {
      return this.Name + " " + this.Level + " " + this.TypeVencedor;
    }
    public string VerificaDanos(Vencedor vencedor, Infame infame)
    {
      if (vencedor.Name == "Arus")
      {
        infame.HP -= 60;
      }
      else
      {
        infame.HP -= 30;
      }
      return this.Name + $" está com {this.HP} de HP.";
    }
  }
}