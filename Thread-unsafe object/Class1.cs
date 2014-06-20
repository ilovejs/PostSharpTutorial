using System.Collections.Generic;
using PostSharp.Patterns.Threading;
/*
 * Don't want to have multiple threads concurrently accessing the same class instance. 
 * This is the Instance policy.
 * 
 * Reason:
 * where some objects are not safe for concurrent use by several threads. 
 * Although these object should theoretically not be accessed concurrently, 
 * it is very hard to proof that it never happens. And when it does happen, 
 * thread-unsafe data structures get corrupted, and symptoms may appear much later. 
 */
namespace Thread_unsafe_object
{
    [ThreadUnsafe]
    public class MyDictionary
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        /*
         * Now when your application executes no two threads will be able to access a single instance of the MyDictionary class at the same time. 
         * If two threads attempt to do this, the second thread will receive a ConcurrentAccessException. 
         * Without the exception, there would be a slight chance that internal Dictionary would become corrupted, because this data structure is not thread safe.
         */
        public void Add(string key, string value)
        {
            this.dictionary.Add(key, value);
        }

        /*
         * Waiving verification
         */
//        [ExplicitlySynchronized]
//        public void Add(string key, string value)
//        {
//            lock (this.dictionary)
//            {
//                this.dictionary.Add(key, value);
//            }
//        } 
    }
}

/*
 More detail:
 * http://www.postsharp.net/threading/thread-unsafe?utm_source=vsx&utm_medium=app&utm_campaign=Learn
 */