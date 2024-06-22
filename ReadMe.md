# RoyalBlade_김주영

## 들어가기 전

시연영상을 보면서, 글을 봐주시면 감사하겠습니다. 싱크는 맞지 않지만, 대부분의 설명이 들어가있으며, 사진과 같이 들어가 보기 쉬울것으로 보입니다.

## 기획 의도

기존 게임과 비슷한 “건물 부수기”라는 게임과 비슷한 형식을 채용하였으며, 오리지날 게임의 게임형식은 스테이지 형식의 수집형 게임과 같았지만, 그런 게임의 특징상 아이템을 모으고, 게임을 하는 것에 그치지만, 요즘 유행하고 있는 로그라이크 형식으로 재창작하여, 종종 나오는 상점을 통해, 스탯을 올리고, 골드를 모아 점수를 채우는 것을 목표로 제작하였습니다.

## 메인 화면구성 설명

![Untitled](RoyalBlade_%E1%84%80%E1%85%B5%E1%86%B7%E1%84%8C%E1%85%AE%E1%84%8B%E1%85%A7%E1%86%BC%20a3fa4595b56048319e157738ba3cded4/Untitled.png)

### 타이틀

먼저 타이틀입니다. 말그대로, 게임의 제목을 나타내는 부분이죠

### 캐릭터

우리가 움직일 수 있는 캐릭터입니다. 캐릭터는 날라오는 블럭에 공격을 하고, 방어를 할 수 있으며, 점프를 하여, 추가 방어를 할 수 있는 캐릭터 입니다.

## 인게임 구조

![Untitled](RoyalBlade_%E1%84%80%E1%85%B5%E1%86%B7%E1%84%8C%E1%85%AE%E1%84%8B%E1%85%A7%E1%86%BC%20a3fa4595b56048319e157738ba3cded4/Untitled%201.png)

### 남은 라운드 수

남아 있는 라운드의 수 입니다.  3~5중 랜덤으로 최대 라운드가 지정되게 되며 지정된 라운드 수가 끝이 나게 되면, 상점창이 나오게 되며, 공격력 또는 방어 쿨타임에 관한 효과를 구매할 수 있습니다.

### 방어 쿨타임에 관한 UI

이 UI는 원작에 있던 방어 시스템을 수동이 아닌 자동시스템으로 변경하게 되었습니다.상점에서 쿨타임을 줄이고, 방해물을 일정 높이 띄울 수 있습니다.

### 점프 버튼

점프를 할 수 있는 버튼입니다. 점프를 하게 되면, 방어 쿨타임을 초기화를 하며, 바닥에 닿을때까지는 점프를 못하게됩니다.

### 공격 버튼입니다.

공격을 실행하게 되며, 공격성공시, 방해물을 일정 높이 띄우게 되며, 기초 공격력인 10을 가지게 되며, 블럭에게 공격을 합니다. 그리고, 공격력은 라운드가 끝나면 생기는 상점창에서 강화를 할 수 있게 됩니다.

### 블럭

![Untitled](RoyalBlade_%E1%84%80%E1%85%B5%E1%86%B7%E1%84%8C%E1%85%AE%E1%84%8B%E1%85%A7%E1%86%BC%20a3fa4595b56048319e157738ba3cded4/Untitled%202.png)

일정시간마다 생성되는 블럭입니다. 

![Untitled](RoyalBlade_%E1%84%80%E1%85%B5%E1%86%B7%E1%84%8C%E1%85%AE%E1%84%8B%E1%85%A7%E1%86%BC%20a3fa4595b56048319e157738ba3cded4/Untitled%203.png)

매 라운드마다 총 3개의 블럭이 간격을 두고 내려오게 됩니다. 각각 일정 체력을 가지고 있으며, 체력비례 랜덤 골드를 지급하게 해주며, 사실상 게임의 주 점수 획득처입니다.

## 상점창 구조

![Untitled](RoyalBlade_%E1%84%80%E1%85%B5%E1%86%B7%E1%84%8C%E1%85%AE%E1%84%8B%E1%85%A7%E1%86%BC%20a3fa4595b56048319e157738ba3cded4/Untitled%204.png)

### 방어 쿨타임 감소

방어 쿨타임을 줄일 수 있는 아이템입니다. 80%~100%의 감소치를 랜덤으로 받을 수 있으며, 방어 성공시 밀어내는 힘을 80%~130%의 보정을 랜덤으로 받을 수 있습니다.

### 공격력 증가

공격력을 증가할 수 있는 아이템입니다. 110% ~ 350%까지 높일 수 있습니다. 수치가 높은 만큼 추가 보정치는 지급하지 않았습니다.

### 아이템 가격 책정 방식

아이템의 가격 책정 방식은 따로 거창하지만, 식을 구성하여 제작을 하였습니다. 구성한 식은 현재 골드의 비율과 총 라운드 수를 가져와 구성하였습니다

- 가격 책정 식
    
    (현재 골드 * 80%~110%) + (100 * 총 라운드 / (45~60)) 이런식으로 구성하여, 현재 골드와 비슷하게 책정되며, 현재 골드보다 높거나 낮을 수 있습니다.
    

### 스킵 버튼

말그대로 아이템을 구매 없이 넘길 수 있는 버튼이며, 유저에게는 따로 효과는 없습니다.

## 게임 오버

![Untitled](RoyalBlade_%E1%84%80%E1%85%B5%E1%86%B7%E1%84%8C%E1%85%AE%E1%84%8B%E1%85%A7%E1%86%BC%20a3fa4595b56048319e157738ba3cded4/Untitled%205.png)

### 현재 스코어

점수라고 해도, 로그라이크의 게임방식을 이용하여 제작한 만큼, 가진 골드를 점수로 이용하여 제작하였습니다.

### 최고 스코어

최고 스코어는 최고인 만큼, 유저가 얻은 최고의 골드를 최고 점수로 지정하였습니다.

### 재시작 버튼

버튼을 누르게 되면, 메인화면으로 이동하게 되며, 처음화면으로 이동이 됩니다.

## 코드 설명

모두 다 적기는 힘들지만, 제작하면서 중요한 코드들의 설명입니다.

- 방해물
    
    ```csharp
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Random = UnityEngine.Random;
    
    public class BrickHPCon : HPControllerBase
    {
        private GoodsManager _goodsManager;
    
        private void Awake()
        {
             _goodsManager = FindObjectOfType<GoodsManager>();
        }
    
        public override void Hit(float dmg)
        {
            _curHP -= dmg;
            Debug.Log($"{_curHP} 남음");
            if (_curHP <= 0)
            {
                Death();
                return;
            }
    
        }
        
        public override void Death()
        {
    			  // 골드 지급
            _goodsManager.GetGold(Random.Range(Mathf.CeilToInt(_maxHP / 2), Mathf.CeilToInt(_maxHP)));
            // 오브젝트 풀링을 위한 함수
             transform.SetParent(PoolManager.SetParentObject(PoolManager.PoolType.GameObject).transform);
            PoolManager.ReturnObjectPool(gameObject);
        }
    
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Attack"))
            {
    			      // 부딪힌 오브젝트에 Damageable 컴포넌트 받아오기
                if (other.TryGetComponent(out Damageable damageable))
                {
    		            // 데미지 부여
                    Hit(damageable.Damage);
                }
            }
        }
    }
    
    ```
    
- 방해물 부모 오브젝트
    
    ```csharp
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Unity.Mathematics;
    using UnityEngine;
    using Random = UnityEngine.Random;
    
    public class BrickParent : MonoBehaviour
    {
        [SerializeField] private GameObject _brickPrefabs;
        [SerializeField] private Vector3 _brickOffset;
        
        private Rigidbody2D _rigid;
    
    		// 토탈 라운드
        public int CurIdx
        {
            get;
            set;
        }
    
        private void Awake()
        {
            _rigid = GetComponent<Rigidbody2D>();
        }
    
        private void OnEnable()
        {
            int ranIdx = Random.Range(3, 6);
            for (int i = 0; i < ranIdx; i++)
            {
                GameObject brick = PoolManager.SpawnObject(_brickPrefabs, transform.position + (_brickOffset * i), quaternion.identity, PoolManager.PoolType.GameObject);
                // NullReference 에러가 날 경우를 대비한 TryGetComponent
                if (brick.TryGetComponent(out BrickHPCon bhp))
                {
    		            // 체력 지정 식
                    bhp.MaxHp = Mathf.RoundToInt( 20 + (CurIdx * 10));
                    bhp.CurHp = bhp.MaxHp;
                }
                // 자식으로 지정함으로써, UpForce로 함께 올라갈 수 있도록
                brick.transform.SetParent(transform);
            }
        }
        
        private void Update()
        {
            if (transform.childCount == 0)
            {
                gameObject.SetActive(false);
            }
        }
    
    		// 일정 높이 올라가기 위한 함수
        public void UpForce(float power)
        {
    				// 남아있는 블럭이 없을때 비활성화
            if (transform.childCount == 0)
            {
                gameObject.SetActive(false);
            }
            // 중력을 초기화 함으로, 제대로 올라갈 수 있음
            _rigid.velocity = Vector3.zero;
            _rigid.AddForce(Vector3.up * power, ForceMode2D.Impulse);
        }
    }
    
    ```
    
- 공격 판정
    
    ```csharp
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    
    public class Damageable : MonoBehaviour
    {
        [SerializeField] private float _damage;
        public float Damage => _damage * _player.AttPower;
        [SerializeField] private float defencePower;
    
        [SerializeField] private GameObject _damageTextPrefab;
    
        private Player _player;
        // 데미지 텍스트를 위한 캔버스
        private Canvas _canvas;
        
        private void Awake()
        {
            _player = transform.parent.GetComponent<Player>();
            _canvas = GameObject.Find("UserCanvas").GetComponent<Canvas>();
        }
    
        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.transform.CompareTag("Brick")){
    		        // 브릭 오브젝트 일때
                if (other.transform.parent.TryGetComponent(out BrickParent bp))
                {
                    Debug.Log("올라감");
                    // 데미지 텍스트 생성
                    DamageText textObj =
                        PoolManager.SpawnObject(_damageTextPrefab, transform.position, Quaternion.identity).GetComponent<DamageText>();
                    textObj.transform.SetParent(_canvas.transform);
                    textObj.transform.localScale = Vector3.one;
                    textObj.SetText($"{_damage}");
                    // 블럭 올리기
                    bp.UpForce(defencePower);
                    gameObject.SetActive(false);
                }
            }
        }
    }
    
    ```
    
- GameManager
    
    ```csharp
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using TMPro;
    using UnityEngine;
    using Random = UnityEngine.Random;
    
    public class GameManager : MonoBehaviour
    {
        public int RemainRound { get; set; }
        public int MaxRemainRound { get; set; }
        
        public bool GameStop { get; set; }
    
        public int TotalRound;
    
        [SerializeField] private GameObject _shopObj;
    
        [SerializeField] private TMP_Text _remainText;
    
        [SerializeField] private GameObject _gameOverPannel;
    
        [SerializeField] private GameObject _inGameButton;
        
        private void Awake()
        {
            MaxRemainRound = Random.Range(3, 6);
    
            _remainText.text = $"{RemainRound}/{MaxRemainRound}";
        }
    
        private void Start()
        {
    		    // 메인화면으로 게임 멈추게
            GameStop = true;
        }
    
        public void StartGame()
        {
    		    // 최대 라운드 지정
            MaxRemainRound = Random.Range(3, 6);
            RemainRound = 0;
            // 게임 시작
            GameStop = false;
        }
    
    		//메인화면 => 게임시작
        public void MainStartGame()
        {
    		    // 게임시작
            StartGame();
            //게임시작을 위한 버튼들 활성화
            _inGameButton.gameObject.SetActive(true);
        }
    
    		//게임오버 화면 띄우기
        public void GameOver()
        {
            _gameOverPannel.SetActive(true);    
        }
    
    		// 남은 라운드 업데이트
        public void UpdateRemain(int val)
        {
            RemainRound += val;
            TotalRound += val;
            _remainText.text = $"{RemainRound}/{MaxRemainRound}";
            if (RemainRound > MaxRemainRound)
            {
                GameStop = true;
                _shopObj.SetActive(true);
                return;
            }
        }
    }
    
    ```
    
- PoolManager
    
    최적화를 위한 Manager이지만 제가 가장 좋아하는 클래스입니다. 제가 게임을 제작하면 무조건 넣는 클래스이며, 편하게 사용할 수 있게 정적 클래스를 이용하여 제작했습니다.
    
    ```csharp
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using System.Linq;
    using JetBrains.Annotations;
    
    public class PoolManager : MonoBehaviour
    {
        public static List<PoolObjectInfo> ObjectPools = new List<PoolObjectInfo>();
    
        [CanBeNull] private GameObject _objectPoolEmptyHolder;
    
        private static GameObject _particleSystemEmpty;
        private static GameObject _gameObjectEmpty;
    
        public enum PoolType
        {
            ParticleSystem,
            GameObject,
            None
        }
    
        public static PoolType PoolingType;
    
        private void Awake()
        {
            SetupEmpties();
        }
    
        void SetupEmpties()
        {
            _objectPoolEmptyHolder = new GameObject("Pooled Objects");
    
            _particleSystemEmpty = new GameObject("Particle Effects");
            _particleSystemEmpty.transform.SetParent(_objectPoolEmptyHolder.transform);
    
            _gameObjectEmpty = new GameObject("GamaeObjects");
            _gameObjectEmpty.transform.SetParent(_objectPoolEmptyHolder.transform);
        }
    
    		// 오브젝트 생성 및 활성화
        public static GameObject SpawnObject(GameObject objectToSpawn, Vector3 spawnPos, Quaternion spawnQuaternion, PoolType poolType = PoolType.None)
        {
            PoolObjectInfo pool = ObjectPools.Find(p => p.LookupString == objectToSpawn.name);
        
            if (pool == null)
            {
                pool = new PoolObjectInfo() { LookupString = objectToSpawn.name };
                ObjectPools.Add(pool);
            }
        
            GameObject spawnableObj = pool.InactiveObjects.FirstOrDefault();
            if (spawnableObj == null)
            {
                GameObject parentObject = SetParentObject(poolType);
                
                spawnableObj = Instantiate(objectToSpawn, spawnPos, spawnQuaternion);
                if (parentObject != null)
                {
                    spawnableObj.transform.SetParent(parentObject.transform);
                }
            }
            else
            {
                spawnableObj.transform.position = spawnPos;
                spawnableObj.transform.rotation = spawnQuaternion;
                pool.InactiveObjects.Remove(spawnableObj);
                spawnableObj.SetActive(true);
            }
    
            return spawnableObj;
        }
    		
    		// 오브젝트 비활성화 밑 풀링에 넣기
        public static void ReturnObjectPool(GameObject obj)
        {
            string goName = obj.name.Substring(0, obj.name.Length - 7);
            
            PoolObjectInfo pool = ObjectPools.Find(q => q.LookupString == goName);
    
            if (pool == null)
            {
                Debug.LogWarning($"Trying to release an object that is not pooled : {obj.name}");
            }
            else
            {
                obj.SetActive(false);
                pool.InactiveObjects.Add(obj);
            }
        }
    
        public static GameObject SetParentObject(PoolType poolType)
        {
            switch (poolType)
            {
                case PoolType.ParticleSystem:
                    return _particleSystemEmpty;
                case PoolType.GameObject:
                    return _gameObjectEmpty;
                case PoolType.None:
                    return null;
                default:
                    return null;
            }
        }
    }
    public class PoolObjectInfo
    {
        public string LookupString;
        public List<GameObject> InactiveObjects = new List<GameObject>();
    }
    ```
    
- Player
    
    ```csharp
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _jumpPower;
    
        [Header("Deffence")] [SerializeField] private Image defenceIcon;
        [SerializeField] private float maxDeffenceTime;
        [SerializeField] private float tempDeffenceTime;
        [SerializeField] private float defencePower;
    
        private GameManager _gameManager;
    
        public float MaxDeffenceTime
        {
            get => maxDeffenceTime * DefCoolDown;
            set => maxDeffenceTime = value;
        }
    
        [field: SerializeField]
        public float DefCoolDown
        {
            get;
            set;
        }
        [field: SerializeField]public float AttPower
        {
            get;
            set;
        }
    
        private Animator _animator;
        private Rigidbody2D _rigid;
    
        private void Awake()
        {
            _gameManager = FindObjectOfType<GameManager>();
            _rigid = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
        }
    
        private void Update()
        {
    	    // 방어 쿨타임 확인
            if (tempDeffenceTime > 0)
            {
                defenceIcon.fillAmount = tempDeffenceTime / MaxDeffenceTime;
                tempDeffenceTime -= Time.deltaTime;
            }
        }
    
        public void Jump()
        {
            if (!CheckGround())
            {
                return;
            }
            //점프 하면 쿨 초기화
            tempDeffenceTime = 0;
            _rigid.AddForce(Vector3.up * _jumpPower, ForceMode2D.Impulse);
        }
    
        public void Attack()
        {
            _animator.SetTrigger("Attack");
        }
        
        bool CheckGround()
        {
    	    // 바닥에 있는지 확인
            return Physics2D.Raycast(transform.position, Vector2.down, 1f, LayerMask.GetMask("Ground"));
        }
    
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.transform.CompareTag("Brick"))
            {
                if (tempDeffenceTime <= 0)
                {
                    Debug.Log("방어함");
                    tempDeffenceTime = MaxDeffenceTime;
                    // 방어를 하면서 블럭 올리기
                    if (other.transform.TryGetComponent(out BrickParent bp))
                    {
                        Debug.Log("올라감");
                        bp.UpForce(defencePower);
                    }
                }
                else
                {
    		            // 게임오버 처리
                    _gameManager.GameOver();
                    gameObject.SetActive(false);
                }
            }
        }
    }
    
    ```
    

## 자세한 부분은 아래 링크로 확인 가능합니다

[https://github.com/gunggme/RoyalBlade_JooYeong](https://github.com/gunggme/RoyalBlade_JooYeong)

[https://github.com/gunggme/RoyalBlade_JooYeong](https://github.com/gunggme/RoyalBlade_JooYeong)
