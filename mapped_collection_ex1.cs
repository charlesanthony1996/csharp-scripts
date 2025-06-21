// # mapped collection -> data structures that map keys to values

// # main example -> dictionary

// # features

// # key value pairs

// # fast lookup by key (hash based)

// # generic and type safe

Dictionary<string, int> ages = new Dictionary<string, int>();
ages["Alice"] = 30;
ages["Bob"] = 25;
ages["Charles"] = 29;

Console.WriteLine(ages["Charles"]);

// Other mapped collections include:

// SortedDictionary<TKey, TValue> – keeps keys sorted

// ConcurrentDictionary<TKey, TValue> – thread-safe version