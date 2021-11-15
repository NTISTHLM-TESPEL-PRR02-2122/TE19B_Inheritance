public class Enemy
{
  public string name;
  public int hp;

  public int x = 0;
  public int y = 0;

  virtual public void Update()
  {
    x++;
  }

}