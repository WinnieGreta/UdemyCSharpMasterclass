using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace UdemyAssignment35
{
    internal class VideoPost : Post
    {
        /* if the user watched entire video without stopping we want to move on
         * without waiting for them to press any key.
         * For this purpose we throw some exception if the key has not been read
         * by console by the time the video reached its end.
         * The code below enables these exceptions
         */
        const int STD_INPUT_HANDLE = -10;

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool CancelIoEx(IntPtr handle, IntPtr lpOverlapped);

        // new properties we add to video post class
        public string VideoURL { get; set; }
        public int Length { get; set; }

        // signals what second of the video is playing right now
        private int Second { get; set; }

        public VideoPost()
        {

        }

        public VideoPost(string title, string sentBy, string videoURL, int length, bool isPublic)
        {
            this.Title = title;
            this.SentBy = sentBy;
            this.VideoURL = videoURL;
            this.Length = length;
            this.IsPublic = isPublic;
            this.Second = 0;
            this.ID = GetNextID();
            // video starts playing when the post is created
            Play();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - by {2} - url {3} - length {4}", 
                this.ID, this.Title, this.SentBy, this.VideoURL, this.Length);
        }

        static Timer timer = null;
        
        private void CountSecondsElapsed(object state)
        {
            Console.WriteLine("Video is at second {0}", ++this.Second);
            if (this.Second == this.Length)
            {
                Console.WriteLine("Video reached its end.");
                /* if the video reached its end we throw an exception to signal
                 * that we no longer need to wait for user to press any key to stop
                 * the video. Exception is caught in Play() method and disrupts
                 * Console.ReadKey() */
                var handle = GetStdHandle(STD_INPUT_HANDLE);
                CancelIoEx(handle, IntPtr.Zero);
                Stop();
            }
        }

        private void Play()
        {
            Console.WriteLine("Started playing video of length {0} seconds. Press any button to stop.", this.Length);
            timer = new Timer(new TimerCallback(CountSecondsElapsed), null, 0, 1000);
            try
            {
                Console.ReadKey();
                Console.WriteLine("Video stopped by a user.");
                Stop();
            }
            catch (InvalidOperationException)
            {

            }
            catch (OperationCanceledException)
            {

            }
            
        }

        private void Stop()
        {
            Console.WriteLine("Video stopped at {0}s.", this.Second);
            // clearing resources we'll no longer need
            timer.Dispose();
        }
    }
}
