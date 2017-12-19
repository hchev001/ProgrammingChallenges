# Challenge Instructions

Creat a function that retunrs the name of the winner in a fight between two fighters.

Each fither takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having health <= 0.

Each fighter will be a Fighter object/instance See the Fither class below in your chose language (c#).

Both health and damagePerAttack will be integers larger than 0. You can mutate the Fighter objects.

public class Fighter {

  public string Name;
  public int Health, DamagePerAttack;
  public Fighters(string name, int health, int damagePerAttack) {
    this.Name = name;
    this.Health = health;
    this.DamagePerAttack = damagePerAttack;
  }
  public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker){}

}
