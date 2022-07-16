using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _seeDistance;
    [SerializeField] private float _attackDistance;

    private Animator _animator;
    private Rigidbody _rigidbody;
    private Transform _target;    
    
    private void Start()
    {
        _target = GameObject.FindWithTag("Player").transform;
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, _target.transform.position) < _seeDistance)
        {
            if (Vector3.Distance(transform.position, _target.transform.position) > _attackDistance)
            {
                _animator.SetBool("Walk", true);
                transform.LookAt(_target.transform);
                transform.Translate(new Vector3(0, 0, _speed * Time.deltaTime));
            }
            else
                StartCoroutine(DelayBeforeAttack());
        }
        else
            _animator.SetBool("Walk", false);
    }

    IEnumerator DelayBeforeAttack()
    {
        _animator.SetBool("Walk", false);
        yield return new WaitForSeconds(0.5f);
        _animator.SetTrigger("Attack");
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            _animator.enabled = false;
            
        }
    }
}
