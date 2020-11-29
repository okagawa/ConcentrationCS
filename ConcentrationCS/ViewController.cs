using Foundation;
using System;
using UIKit;

namespace ConcentrationCS
{
    public partial class ViewController : UIViewController
    {
        private static int flipCount = 0;
        public int FlipCount
        {
            set
            {
                flipCount = value;
                flipCountLabel.Text = String.Format("Flips: {0}", flipCount);
            }
            get
            {
                return flipCount;
            }
        }

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void touchCard(UIButton sender)
        {
            FlipCount = FlipCount+1;

            flipCard("👻", sender);
            //throw new NotImplementedException();
        }

        partial void touchCard2(UIButton sender)
        {
            FlipCount = FlipCount + 1;

            flipCard("🎃", sender);
            // throw new NotImplementedException();
        }

        public void flipCard(String emoji, UIButton button)
        {
            if( button.CurrentTitle == emoji)
            {
                button.SetTitle("", UIControlState.Normal);
                button.BackgroundColor = UIColor.Orange;
            } else
            {
                button.SetTitle(emoji, UIControlState.Normal);
                button.BackgroundColor = UIColor.White;
            }
        }

    }
}
