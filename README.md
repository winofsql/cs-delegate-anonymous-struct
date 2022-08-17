# cs-delegate-struct

## namespace form_03

### 定義済み delegate + ラムダ式で匿名メソッドの定義
```cs
    private Func<string> myDbg = () => { return "DBG"; };
    private Action<string> print = (message) => { Debug.WriteLine($"DBG:{message}"); };

```

### 構造体
```cs
    private struct DbConnect {
            public string host;
            public string user;
            public string password;
            public string database;
    }
```
