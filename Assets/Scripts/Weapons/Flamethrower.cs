using UnityEngine;

public class Flamethrower : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        float offsetY = 0.5f;
        Instantiate(Bullet, new Vector2(shootPoint.position.x, shootPoint.position.y - offsetY), Quaternion.identity);
    }
}