
Enemy e1 = new Enemy();

Goomba g1 = new Goomba();

g1.hp = 100;



Enemy e2 = new Goomba();

// Goomba g2 = new Enemy();


// e1.Update();
// g1.Update();

List<Enemy> enemies = new List<Enemy>();

enemies.Add(new Goomba());

for (int i = 0; i < enemies.Count; i++)
{
  enemies[i].Update();
}
