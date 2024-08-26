namespace DSAndAlgoConcepts.Hashing
{
    internal class HashMap<K, V>
    {
        class Node
        {
            public K key;
            public V value;

            public Node(K key, V value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private int size;
        private int N;
        LinkedList<Node>[] buckets;

        public HashMap()
        {
            this.N = 4;
            this.buckets = new LinkedList<Node>[4];
            for (int i = 0; i < 4; i++)
            {
                this.buckets[i] = new LinkedList<Node>();
            }
        }

        private int hashFunction(K key)
        {
            int hashCode = key.GetHashCode();
            hashCode = Math.Abs(hashCode) % N;
            return hashCode;

        }

        private int SearchInLinkedList(K key, int bucketIndex)
        {
            var ll = buckets[bucketIndex];
            int di = 0;
            for (int i = 0; i < ll.Count; i++)
            {
                Node node = ll.ElementAt(i);
                if (node.key.Equals(key))
                    return di;
                di++;

            }
            return -1;
        }
        private void rehash()
        {
            var oldbucket = buckets;
            N = 2 * N;
            buckets = new LinkedList<Node>[N];
            for (int i = 0; buckets.Length > 0; i++)
            {
                buckets[i] = new LinkedList<Node>();

            }
            for (int i = 0; oldbucket.Length > 0; i++)
            {
                var ll = oldbucket[i];
                for (int j = 0; j < ll.Count; j++)
                {
                    var node = ll.ElementAt(j);
                    ll.Remove(node);
                    put(node.key, node.value);
                }

            }

        }

        public bool containsKey(K key)
        {
            var bucketIndex = hashFunction(key);
            var dataIndex = SearchInLinkedList(key, bucketIndex);

            if (bucketIndex != -1)
                return true;
            else
                return false;
        }

        public V getValue(K key)
        {
            var bucketIndex = hashFunction(key);
            var dataIndex = SearchInLinkedList(key, bucketIndex);
            if (bucketIndex != -1)
            {
                Node node = buckets[bucketIndex].ElementAt(dataIndex);
                return node.value;

            }
            else
                return default(V);
        }

        public V Remove(K key)
        {
            var bucketIndex = hashFunction(key);
            var dataIndex = SearchInLinkedList(key, bucketIndex);
            if (bucketIndex != -1)
            {
                Node node = buckets[bucketIndex].ElementAt(dataIndex);
                buckets[bucketIndex].Remove(node);
                size--;
                return node.value;

            }
            else
                return default(V);
        }

        public List<K> GetKeys()
        {
            var keys = new List<K>();
            foreach (var bucket in buckets)
            {
                foreach (var node in bucket)
                {
                    keys.Add(node.key);
                }
            }
            return keys;
        }

        public bool isEmpty()
            => size == 0;

        //O(Lambda) Lambda= size/N;
        public void put(K key, V value)
        {
            var bucketIndex = hashFunction(key);
            var dataIndex = SearchInLinkedList(key, bucketIndex);

            if (dataIndex != -1)
            {
                Node node = buckets[bucketIndex].ElementAt(dataIndex);
                node.value = value;

            }
            else
            {
                buckets[bucketIndex].AddLast(new Node(key, value));
                size++;
            }
            double lambda = size / N;
            if (lambda > 2)
                rehash();
        }
    }

    class MainClass
    {
        //static void Main(string[] args)
        //{
        //    HashMap<string, int> hashMap = new HashMap<string, int>();
        //    hashMap.put("Canada", 40);
        //    hashMap.put("USA", 140);
        //    hashMap.put("India", 1400);
        //    hashMap.put("China", 1300);
        //    hashMap.put("Pakistan", 55);

        //    Console.WriteLine(hashMap.containsKey("India"));
        //    Console.WriteLine(hashMap.getValue("India"));
        //    Console.WriteLine(string.Join(',', hashMap.GetKeys()));
        //    Console.WriteLine(hashMap.isEmpty());
        //    Console.WriteLine(hashMap.Remove("China"));
        //}
    }
}
