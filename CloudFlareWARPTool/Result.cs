namespace CloudFlareWARPTool
{
    public class Result
    {
        private int success, fail;
        private readonly object successLock, failLock;

        public Result()
        {
            successLock = new object();
            failLock = new object();
        }

        public (int, int) getStatus()
        {
            lock (successLock)
            {
                lock (failLock)
                {
                    return (success, fail);
                }
            }
        }

        public void addSuccess()
        {
            lock (successLock)
            {
                ++success;
            }
        }

        public void addFail()
        {
            lock (failLock)
            {
                ++fail;
            }
        }
    }
}