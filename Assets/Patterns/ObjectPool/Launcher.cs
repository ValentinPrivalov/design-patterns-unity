using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Launcher : MonoBehaviour
{
    [SerializeField] Bullet bulletPrefab;
    private IObjectPool<Bullet> bulletPool;
    private bool collectionChecks = true; // Collection checks will throw errors if we try to release an item that is already in the pool.
    private int defaultCapacity = 5;
    private int maxPoolSize = 5;

    private void Awake()
    {
        bulletPool = new ObjectPool<Bullet>(
            CreatePooledItem,
            OnGet,
            OnRelease,
            OnDestroyPoolObject,
            collectionChecks,
            defaultCapacity,
            maxPoolSize
        );
    }

    private Bullet CreatePooledItem()
    {
        Bullet bullet = Instantiate(bulletPrefab);
        bullet.SetPool(bulletPool);
        return bullet;
    }

    private void OnGet(Bullet bullet)
    {
        bullet.gameObject.SetActive(true);
    }

    private void OnRelease(Bullet bullet)
    {
        bullet.transform.position = transform.position;
        bullet.gameObject.SetActive(false);
    }

    private void OnDestroyPoolObject(Bullet bullet)
    {
        Destroy(bullet.gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bulletPool.Get();
        }
    }
}
