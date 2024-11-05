using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Drawing2D;
using System.Linq;


namespace StudyZone
{
    public partial class BreakForm : Form
    {
        private KeyboardHook keyboardHook;
        private bool allowClose = false; // Flag to control form closing
        private int breakSeconds = 0;
        private int totalBreakSeconds = 0;
        private Label lblCountdownTimer;
        private Label lblQuote;
        private CircularProgressBar progressBar;
        private List<string> musicFiles = new List<string>();
        private List<Image> backgroundImages = new List<Image>();
        private SoundPlayer player;
        //private List<string> motivationalQuotes = new List<string>
        //{
        //    "“The future depends on what you do today.” – Mahatma Gandhi",
        //    "“Don't watch the clock; do what it does. Keep going.” – Sam Levenson",
        //    "“Success is not the key to happiness. Happiness is the key to success.” – Albert Schweitzer",
        //    // Add more quotes as desired
        //};
        private List<string> motivationalQuotes = new List<string>
        {
        "“The future depends on what you do today.” – Mahatma Gandhi",
        "“Don't watch the clock; do what it does. Keep going.” – Sam Levenson",
        "“Success is not the key to happiness. Happiness is the key to success.” – Albert Schweitzer",
        "“The only way to do great work is to love what you do.” – Steve Jobs",
        "“It does not matter how slowly you go as long as you do not stop.” – Confucius",
        "“You miss 100% of the shots you don’t take.” – Wayne Gretzky",
        "“Act as if what you do makes a difference. It does.” – William James",
        "“Success is walking from failure to failure with no loss of enthusiasm.” – Winston Churchill",
        "“Don’t wait for opportunity. Create it.” – George Bernard Shaw",
        "“You have within you right now, everything you need to deal with whatever the world can throw at you.” – Brian Tracy",
        "“The best time to plant a tree was 20 years ago. The second best time is now.” – Chinese Proverb",
        "“If you can dream it, you can achieve it.” – Zig Ziglar",
        "“The harder you work for something, the greater you’ll feel when you achieve it.” – Unknown",
        "“Success is not in what you have, but who you are.” – Bo Bennett",
        "“Everything you’ve ever wanted is on the other side of fear.” – George Addair",
        "“The secret of getting ahead is getting started.” – Mark Twain",
        "“Doubt kills more dreams than failure ever will.” – Suzy Kassem",
        "“Don’t be afraid to give up the good to go for the great.” – John D. Rockefeller",
        "“You don’t have to be great to start, but you have to start to be great.” – Zig Ziglar",
        "“It’s not whether you get knocked down; it’s whether you get up.” – Vince Lombardi",
        "“The only limit to our realization of tomorrow will be our doubts of today.” – Franklin D. Roosevelt",
        "“Setting goals is the first step in turning the invisible into the visible.” – Tony Robbins",
        "“Hardships often prepare ordinary people for an extraordinary destiny.” – C.S. Lewis",
        "“What we think, we become.” – Buddha",
        "“Push yourself, because no one else is going to do it for you.” – Unknown",
        "“Great things never came from comfort zones.” – Unknown",
        "“Success is how high you bounce when you hit bottom.” – George S. Patton",
        "“Dream big and dare to fail.” – Norman Vaughan",
        "“Your time is limited, so don’t waste it living someone else’s life.” – Steve Jobs",
        "“If you are not willing to risk the usual, you will have to settle for the ordinary.” – Jim Rohn",
        "“I find that the harder I work, the more luck I seem to have.” – Thomas Jefferson",
        "“If you want to achieve greatness stop asking for permission.” – Anonymous",
        "“Go as far as you can see; when you get there, you’ll be able to see further.” – Thomas Carlyle",
        "“Do not wait; the time will never be ‘just right.’ Start where you stand.” – Napoleon Hill",
        "“Success seems to be connected with action. Successful people keep moving.” – Conrad Hilton",
        "“Our greatest glory is not in never falling, but in rising every time we fall.” – Confucius",
        "“Failure will never overtake me if my determination to succeed is strong enough.” – Og Mandino",
        "“If you’re going through hell, keep going.” – Winston Churchill",
        "“Never give up on a dream just because of the time it will take to accomplish it. The time will pass anyway.” – Earl Nightingale",
        "“You only live once, but if you do it right, once is enough.” – Mae West",
        "“A goal without a plan is just a wish.” – Antoine de Saint-Exupéry",
        "“Believe you can and you're halfway there.” – Theodore Roosevelt",
        "“Don't let yesterday take up too much of today.” – Will Rogers",
        "“Perseverance is not a long race; it is many short races one after the other.” – Walter Elliot",
        "“Aim for the moon. If you miss, you may hit a star.” – W. Clement Stone",
        "“Keep your eyes on the stars, and your feet on the ground.” – Theodore Roosevelt",
        "“I attribute my success to this: I never gave or took any excuse.” – Florence Nightingale",
        "“The only person you are destined to become is the person you decide to be.” – Ralph Waldo Emerson",
        "“Don’t wish it were easier. Wish you were better.” – Jim Rohn",
        "“The biggest risk is not taking any risk.” – Mark Zuckerberg",
        "“Your life only gets better when you get better.” – Brian Tracy",
        "“The difference between ordinary and extraordinary is that little extra.” – Jimmy Johnson",
        "“No one is perfect - that’s why pencils have erasers.” – Wolfgang Riebe",
        "“It’s hard to beat a person who never gives up.” – Babe Ruth",
        "“It always seems impossible until it’s done.” – Nelson Mandela",
        "“Life begins at the end of your comfort zone.” – Neale Donald Walsch",
        "“You’re braver than you believe, stronger than you seem, and smarter than you think.” – A.A. Milne",
        "“Opportunities don't happen. You create them.” – Chris Grosser",
        "“Sometimes we’re tested not to show our weaknesses, but to discover our strengths.” – Unknown",
        "“Great things never come from comfort zones.” – Anonymous",
        "“Success is not final, failure is not fatal: It is the courage to continue that counts.” – Winston Churchill",
        "“Life isn’t about waiting for the storm to pass, it’s about learning to dance in the rain.” – Vivian Greene",
        "“Do what you can with all you have, wherever you are.” – Theodore Roosevelt",
        "“A champion is defined not by their wins but by how they can recover when they fall.” – Serena Williams",
        "“Do what you love and success will follow. Passion is the fuel behind a successful career.” – Meg Whitman",
        "“The best revenge is massive success.” – Frank Sinatra",
        "“Start where you are. Use what you have. Do what you can.” – Arthur Ashe",
        "“If you don’t like the road you’re walking, start paving another one.” – Dolly Parton",
        "“Opportunities don't happen, you create them.” – Chris Grosser",
        "“The road to success and the road to failure are almost exactly the same.” – Colin R. Davis",
        "“Limitations live only in our minds. But if we use our imaginations, our possibilities become limitless.” – Jamie Paolinetti",
        "“Do one thing every day that scares you.” – Eleanor Roosevelt",
        "“The only place where success comes before work is in the dictionary.” – Vidal Sassoon",
        "“Hard work beats talent when talent doesn’t work hard.” – Tim Notke",
        "“Do what you feel in your heart to be right – for you’ll be criticized anyway.” – Eleanor Roosevelt",
        "“Success usually comes to those who are too busy to be looking for it.” – Henry David Thoreau",
        "“You don’t have to be perfect to be amazing.” – Unknown",
        "“Dream bigger. Do bigger.” – Unknown",
        "“It is never too late to be what you might have been.” – George Eliot",
        "“Only those who dare to fail greatly can ever achieve greatly.” – Robert F. Kennedy",
        "“You can’t use up creativity. The more you use, the more you have.” – Maya Angelou",
        "“Sometimes later becomes never. Do it now.” – Unknown",
        "“The only way to achieve the impossible is to believe it is possible.” – Charles Kingsleigh",
        "“Do what you can, with what you have, where you are.” – Theodore Roosevelt",
        "“It’s not the years in your life that count. It’s the life in your years.” – Abraham Lincoln",
        "“Difficulties strengthen the mind, as labor does the body.” – Seneca",
        "“Your limitation—it’s only your imagination.” – Unknown",
        "“Whatever you are, be a good one.” – Abraham Lincoln",
        "“Quality is not an act, it is a habit.” – Aristotle",
        "“Strength does not come from physical capacity. It comes from an indomitable will.” – Mahatma Gandhi",
        "“Stay foolish to stay sane.” – Maxime Lagacé",
        "“Stay hungry, stay foolish.” – Steve Jobs",
        "“Challenges are what make life interesting. Overcoming them is what makes life meaningful.” – Joshua J. Marine",
        "“Don’t let the fear of losing be greater than the excitement of winning.” – Robert Kiyosaki",
        "“If opportunity doesn’t knock, build a door.” – Milton Berle",
        "“Success is not just about what you accomplish in your life; it’s about what you inspire others to do.” – Unknown",
        "“To be a champ, you have to believe in yourself when no one else will.” – Sugar Ray Robinson",
        "“Hustle beats talent when talent doesn’t hustle.” – Ross Simmonds",
        "“You don’t need to be better than anyone else; you just need to be better than you used to be.” – Wayne Dyer",
        "“Believe in yourself, push your limits, experience life, conquer your goals, and be happy.” – Joel Brown",
        "“Success doesn’t just find you. You have to go out and get it.” – Unknown",
        "“Your mind is a powerful thing. When you fill it with positive thoughts, your life will start to change.” – Unknown",
        "“The best way to get started is to quit talking and begin doing.” – Walt Disney",
        "“Nothing worth having comes easy.” – Unknown",
        "“Little by little, one travels far.” – J.R.R. Tolkien",
        "“Life has no limitations, except the ones you make.” – Les Brown",
        "“In the middle of every difficulty lies opportunity.” – Albert Einstein",
        "“The secret of success is to do the common thing uncommonly well.” – John D. Rockefeller Jr.",
        "“The difference between who you are and who you want to be is what you do.” – Unknown",
        "“Do what you love and the money will follow.” – Marsha Sinetar",
        "“Good things come to people who wait, but better things come to those who go out and get them.” – Unknown",
        "“The only difference between ordinary and extraordinary is that little extra.” – Jimmy Johnson",
        "“A winner is a dreamer who never gives up.” – Nelson Mandela",
        "“Success is not final; failure is not fatal: It is the courage to continue that counts.” – Winston Churchill",
        "“The harder the struggle, the more glorious the triumph.” – Swami Sivananda",
        "“It’s not about ideas. It’s about making ideas happen.” – Scott Belsky",
        "“Work hard in silence, let your success be your noise.” – Frank Ocean",
        "“Don’t stop until you’re proud.” – Unknown",
        "“If you’re not willing to risk the usual, you’ll have to settle for the ordinary.” – Jim Rohn",
        "“What we achieve inwardly will change outer reality.” – Plutarch",
        "“Make each day your masterpiece.” – John Wooden",
        "“You don’t need to have it all figured out to move forward.” – Unknown",
        "“The difference between try and triumph is just a little umph!” – Marvin Phillips",
        "“The journey of a thousand miles begins with one step.” – Lao Tzu",
        "“Always do your best. What you plant now, you will harvest later.” – Og Mandino",
        "“You’re never a loser until you quit trying.” – Mike Ditka",
        "“Dream as if you’ll live forever, live as if you’ll die today.” – James Dean",
        "“Focus on being productive instead of busy.” – Tim Ferriss",
        "“Don’t watch the clock; do what it does. Keep going.” – Sam Levenson",
        "“It’s going to be hard, but hard does not mean impossible.” – Unknown",
        "“Success isn’t overnight. It’s when every day you get a little better than the day before. It all adds up.” – Dwayne Johnson",
        "“You have to fight through some bad days to earn the best days of your life.” – Unknown",
        "“When we strive to become better than we are, everything around us becomes better too.” – Paulo Coelho",
        "“You must do the thing you think you cannot do.” – Eleanor Roosevelt",
        "“The harder you fall, the higher you bounce.” – Unknown",
        "“Action is the foundational key to all success.” – Pablo Picasso",
        "“Do something today that your future self will thank you for.” – Sean Patrick Flanery",
        "“Small daily improvements over time lead to stunning results.” – Robin Sharma",
        "“Happiness is not something ready-made. It comes from your own actions.” – Dalai Lama",
        "“Be willing to be a beginner every single morning.” – Meister Eckhart",
        "“Don’t wait. The time will never be just right.” – Napoleon Hill",
        "“We become what we think about.” – Earl Nightingale",
        "“Nothing will work unless you do.” – Maya Angelou",
        "“Don’t downgrade your dream just to fit your reality, upgrade your conviction to match your destiny.” – Stuart Scott",
        "“One day or day one. You decide.” – Unknown",
        "“There are no limits to what you can accomplish, except the limits you place on your own thinking.” – Brian Tracy",
        "“Failure is simply the opportunity to begin again, this time more intelligently.” – Henry Ford",
        "“Dream bigger. Start smaller. Act now.” – Robin Sharma",
        "“Opportunities multiply as they are seized.” – Sun Tzu",
        "“The only person you should try to be better than is the person you were yesterday.” – Unknown",
        "“The only thing standing between you and your goal is the story you keep telling yourself as to why you can’t achieve it.” – Jordan Belfort",
        "“Success is not how high you have climbed, but how you make a positive difference to the world.” – Roy T. Bennett",
        "“The key to success is to focus on goals, not obstacles.” – Unknown",
        "“If you want something you’ve never had, you must be willing to do something you’ve never done.” – Thomas Jefferson",
        "“What you get by achieving your goals is not as important as what you become by achieving your goals.” – Zig Ziglar",
        "“Life is 10% what happens to us and 90% how we react to it.” – Charles R. Swindoll",
        "“The mind is everything. What you think you become.” – Buddha",
        "“Do what you have to do until you can do what you want to do.” – Oprah Winfrey",
        "“Don't be pushed around by the fears in your mind. Be led by the dreams in your heart.” – Roy T. Bennett",
        "“To accomplish great things, we must not only act, but also dream; not only plan, but also believe.” – Anatole France",
        "“I am not a product of my circumstances. I am a product of my decisions.” – Stephen Covey",
        "“Success means doing the best we can with what we have.” – Zig Ziglar",
        "“The only way to discover the limits of the possible is to go beyond them into the impossible.” – Arthur C. Clarke",
        "“Believe in your infinite potential. Your only limitations are those you set upon yourself.” – Roy T. Bennett",
        "“Don’t count the days; make the days count.” – Muhammad Ali",
        "“Do not wait to strike till the iron is hot, but make it hot by striking.” – William Butler Yeats",
        "“I am thankful for all of those who said NO to me. It’s because of them I’m doing it myself.” – Albert Einstein",
        "“Success is the sum of small efforts, repeated day-in and day-out.” – Robert Collier",
        "“What lies behind us and what lies before us are tiny matters compared to what lies within us.” – Ralph Waldo Emerson",
        "“The only journey is the one within.” – Rainer Maria Rilke",
        "“Happiness is not the absence of problems; it’s the ability to deal with them.” – Steve Maraboli",
        "“What you do today can improve all your tomorrows.” – Ralph Marston",
        "“Don’t let the noise of others’ opinions drown out your own inner voice.” – Steve Jobs",
        "“When everything seems to be going against you, remember that the airplane takes off against the wind, not with it.” – Henry Ford",
        "“Sometimes we're tested not to show our weaknesses, but to discover our strengths.” – Unknown",
        "“Believe you can and you’re halfway there.” – Theodore Roosevelt",
        "“Success is not how high you have climbed, but how you make a positive difference to the world.” – Roy T. Bennett",
        "“Learn as if you will live forever, live like you will die tomorrow.” – Mahatma Gandhi",
        "“Your passion is waiting for your courage to catch up.” – Isabelle Lafleche",
        "“You only fail when you stop trying.” – Unknown",
        "“You are never too old to set another goal or to dream a new dream.” – C.S. Lewis",
        "“Dream it. Wish it. Do it.” – Unknown",
        "“Little things make big days.” – John Wooden",
        "“Don’t stop when you’re tired. Stop when you’re done.” – Unknown",
        "“Wake up with determination. Go to bed with satisfaction.” – Unknown",
        "“Do something today that your future self will thank you for.” – Unknown",
        "“If you want to fly, give up everything that weighs you down.” – Buddha",
        "“Sometimes you win, sometimes you learn.” – John Maxwell",
        "“Don’t wait for opportunity. Create it.” – Unknown",
        "“Great things never come from comfort zones.” – Unknown",
        "“Dream it. Believe it. Build it.” – Unknown",
        "“Do it with passion, or not at all.” – Rosa Nouchette Carey",
        "“Success doesn’t come from what you do occasionally. It comes from what you do consistently.” – Marie Forleo",
        "“To be successful you must accept all challenges that come your way. You can’t just accept the ones you like.” – Mike Gafka",
        "“Never stop doing your best just because someone doesn’t give you credit.” – Kamari aka Lyrikal",
        "“Your life is as good as your mindset.” – Unknown",
        "“Stop doubting yourself, work hard, and make it happen.” – Unknown",
        "“Stay positive. Better days are on their way.” – Unknown",
        "“Work hard in silence; let success make the noise.” – Frank Ocean",
        "“Success is not for the lazy.” – Unknown",
        "“It’s not about perfect. It’s about effort.” – Jillian Michaels",
        "“When you feel like quitting, think about why you started.” – Unknown",
        "“It’s going to be hard, but hard does not mean impossible.” – Unknown",
        "“Believe in yourself and all that you are. Know that there is something inside you that is greater than any obstacle.” – Christian D. Larson",
        "“Your only limit is your mind.” – Unknown",
        "“Don’t wait for the right opportunity, create it.” – George Bernard Shaw",
        "“Success is the sum of small efforts repeated day in and day out.” – Robert Collier",
        "“The difference between who you are and who you want to be is what you do.” – Unknown",
        "“Stay positive, work hard, make it happen.” – Unknown",
        "“Don’t count the days, make the days count.” – Muhammad Ali",
        "“Success is the sum of small efforts, repeated day in and day out.” – Robert Collier",
        "“The future belongs to those who believe in the beauty of their dreams.” – Eleanor Roosevelt",
        "“Keep going. Everything you need will come to you at the perfect time.” – Unknown",
        "“You have to be at your strongest when you’re feeling at your weakest.” – Unknown",
        "“Difficult roads always lead to beautiful destinations.” – Zig Ziglar",
        "“Believe you can and you’re halfway there.” – Theodore Roosevelt",
        "“You’re allowed to scream, you’re allowed to cry, but do not give up.” – Unknown",
        "“Be so good they can’t ignore you.” – Steve Martin",
        "“Your passion is waiting for your courage to catch up.” – Isabelle Lafleche",
        "“Success doesn’t just come and find you, you have to go out and get it.” – Unknown",
        "“Don’t limit your challenges, challenge your limits.” – Unknown",
        "“Life is not about finding yourself. Life is about creating yourself.” – George Bernard Shaw",
        "“Be kind whenever possible. It is always possible.” – Dalai Lama",
        "“The only person you should try to be better than is the person you were yesterday.” – Unknown",
        "“What seems to us as bitter trials are often blessings in disguise.” – Oscar Wilde",
        "“You can’t go back and change the beginning, but you can start where you are and change the ending.” – C.S. Lewis",
        "“Stay strong, stay positive, and never give up.” – Roy T. Bennett",
        "“The most effective way to do it, is to do it.” – Amelia Earhart",
        "“If you want to lift yourself up, lift up someone else.” – Booker T. Washington",
        "“Don’t let yesterday take up too much of today.” – Will Rogers",
        "“Success doesn’t happen to you; it happens because of you.” – Grant Cardone",
        "“Don’t watch the clock; do what it does. Keep going.” – Sam Levenson",
        "“Strive not to be a success, but rather to be of value.” – Albert Einstein",
        "“Great minds discuss ideas; average minds discuss events; small minds discuss people.” – Eleanor Roosevelt",
        "“It does not matter how slowly you go, as long as you do not stop.” – Confucius",
        "“Your imagination is your preview of life’s coming attractions.” – Albert Einstein",
        "“Success is to wake up each morning and consciously decide that today will be the best day of your life.” – Ken Poirot",
        "“Life is too short to be small.” – Benjamin Disraeli",
        "“Success only comes to those who dare to attempt.” – Mallika Tripathi",
        "“No masterpiece was ever created by a lazy artist.” – Salvador Dali",
        "“You get in life what you have the courage to ask for.” – Oprah Winfrey",
        "“Do not be embarrassed by your failures; learn from them and start again.” – Richard Branson",
        "“Success is liking yourself, liking what you do, and liking how you do it.” – Maya Angelou",
        "“When you cease to dream you cease to live.” – Malcolm Forbes",
        "“You are never too old to reinvent yourself.” – Steve Harvey",
        "“A goal is a dream with a deadline.” – Napoleon Hill",
        "“Dream big dreams. Only big dreams have the power to move men’s souls.” – Marcus Aurelius",
        "“You don’t need to see the whole staircase, just take the first step.” – Martin Luther King Jr.",
        "“Even if you’re on the right track, you’ll get run over if you just sit there.” – Will Rogers",
        "“It’s not whether you get knocked down, it’s whether you get up.” – Vince Lombardi",
        "“The best way to predict the future is to create it.” – Peter Drucker",
        "“Be brave. Take risks. Nothing can substitute experience.” – Paulo Coelho",
        "“If you cannot do great things, do small things in a great way.” – Napoleon Hill",
        "“Turn your wounds into wisdom.” – Oprah Winfrey",
        "“Success is not how high you have climbed, but how you make a positive difference to the world.” – Roy T. Bennett",
        "“Success is no accident. It is hard work, perseverance, learning, studying, sacrifice and most of all, love of what you are doing.” – Pelé",
        "“Live as if you were to die tomorrow. Learn as if you were to live forever.” – Mahatma Gandhi",
        "“The only limit to our realization of tomorrow is our doubts of today.” – Franklin D. Roosevelt",
        "“Never bend your head. Always hold it high. Look the world straight in the eye.” – Helen Keller",
        "“Go the extra mile. It’s never crowded there.” – Wayne Dyer",
        "“You can waste your lives drawing lines. Or you can live your life crossing them.” – Shonda Rhimes",
        "“Don’t quit. Suffer now and live the rest of your life as a champion.” – Muhammad Ali",
        "“Success is where preparation and opportunity meet.” – Bobby Unser",
        "“To live a creative life, we must lose our fear of being wrong.” – Joseph Chilton Pearce",
        "“Success is a journey, not a destination.” – Ben Sweetland",
        "“The road to success is dotted with many tempting parking spaces.” – Will Rogers",
        "“You can, you should, and if you’re brave enough to start, you will.” – Stephen King",
        "“Don’t let what you cannot do interfere with what you can do.” – John Wooden",
        "“Success seems to be connected with action. Successful people keep moving. They make mistakes, but they don’t quit.” – Conrad Hilton",
        "“Be the change that you wish to see in the world.” – Mahatma Gandhi",
        "“You measure the size of the accomplishment by the obstacles you had to overcome to reach your goals.” – Booker T. Washington",
        "“If you cannot do great things, do small things in a great way.” – Napoleon Hill",
        "“You are confined only by the walls you build yourself.” – Andrew Murphy",
        "“Go confidently in the direction of your dreams! Live the life you’ve imagined.” – Henry David Thoreau",
        "“Be yourself; everyone else is already taken.” – Oscar Wilde",
        "“Motivation is what gets you started. Habit is what keeps you going.” – Jim Ryun",
        "“Success is the sum of small efforts, repeated day in and day out.” – Robert Collier",
        "“There is no elevator to success. You have to take the stairs.” – Zig Ziglar",
        "“Happiness is not something ready-made. It comes from your own actions.” – Dalai Lama",
        "“A journey of a thousand miles begins with a single step.” – Lao Tzu",
        "“Do not wait; the time will never be ‘just right.’ Start where you stand, and work with whatever tools you may have at your command, and better tools will be found as you go along.” – George Herbert",
        "“The way to get started is to quit talking and begin doing.” – Walt Disney",
        "“In order to succeed, we must first believe that we can.” – Nikos Kazantzakis",
        "“The harder the conflict, the more glorious the triumph.” – Thomas Paine",
        "“The journey of a thousand miles begins with one step.” – Lao Tzu",
        "“Failure is the condiment that gives success its flavor.” – Truman Capote",
        "“The man who has confidence in himself gains the confidence of others.” – Hasidic Proverb",
        "“You have to expect things of yourself before you can do them.” – Michael Jordan",
        "“Always do your best. What you plant now, you will harvest later.” – Og Mandino",
        "“You are braver than you believe, stronger than you seem, and smarter than you think.” – A.A. Milne",
        "“Whether you think you can or you think you can’t, you’re right.” – Henry Ford",
        "“The only person you should try to be better than is the person you were yesterday.” – Anonymous",
        "“There is only one way to avoid criticism: do nothing, say nothing, and be nothing.” – Aristotle",
        "“There are no secrets to success. It is the result of preparation, hard work, and learning from failure.” – Colin Powell",
        "“We generate fears while we sit. We overcome them by action.” – Dr. Henry Link",
        "“What seems to us as bitter trials are often blessings in disguise.” – Oscar Wilde",
        "“The distance between insanity and genius is measured only by success.” – Bruce Feirstein",
        "“Your true success in life begins only when you make the commitment to become excellent at what you do.” – Brian Tracy",
        "“Focus on being productive instead of busy.” – Tim Ferriss",
        "“Action is the foundational key to all success.” – Pablo Picasso",
        "“The only person you should try to be better than is the person you were yesterday.” – Unknown",
        "“The way to get started is to quit talking and begin doing.” – Walt Disney",
        "“To be successful you must accept all challenges that come your way. You can’t just accept the ones you like.” – Mike Gafka",
        "“The harder you work, the luckier you get.” – Gary Player",
        // Additional quotes can be added here following the same format.
        };

        // Add these fields at the class level
        private List<Particle> particles = new List<Particle>();
        private Timer particleTimer;
        private Stopwatch stopwatch;
        private float lastFrameTime = 0f;
        private static Random rand = new Random();
        private int maxParticles = 100; // Set an appropriate limit


        public BreakForm()
        {
            InitializeComponent();

            // Form settings
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black;
            this.TopMost = true;
            this.KeyPreview = true;

            // Initialize controls
            InitializeTimerLabel();
            InitializeQuoteLabel();
            InitializeProgressBar();
            this.Resize += BreakForm_Resize;

            // Initialize and start the particle timer in OnLoad or here
            InitializeParticleSystem();
            // Enable double buffering to reduce flickering and improve rendering performance
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);


            LoadMusicFiles();
            LoadBackgroundImages();
            PlayRandomMusic();
            SetRandomBackgroundImage();
        }

        private void LoadBackgroundImages()
        {
            string imagesFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

            if (Directory.Exists(imagesFolderPath))
            {
                // Get all image file paths in the directory
                var imageFiles = Directory.GetFiles(imagesFolderPath, "*.jpg")
                                           .Concat(Directory.GetFiles(imagesFolderPath, "*.png"))
                                           .OrderBy(_ => Guid.NewGuid()) // Shuffle images
                                           .Take(2) // Take only 5 random images for this session
                                           .ToList();

                foreach (string file in imageFiles)
                {
                    try
                    {
                        using (var bmpTemp = new Bitmap(file))
                        {
                            backgroundImages.Add(new Bitmap(bmpTemp));
                        }
                        Debug.WriteLine($"Successfully loaded image: {file}");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error loading image {file}: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("مجلد الصور غير موجود. يرجى التأكد من وجوده.");
            }
        }

        private void SetRandomBackgroundImage()
        {
            string imagesFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

            if (Directory.Exists(imagesFolderPath))
            {
                string[] allFiles = Directory.GetFiles(imagesFolderPath, "*.jpg")
                    .Concat(Directory.GetFiles(imagesFolderPath, "*.png")).ToArray();

                if (allFiles.Length > 0)
                {
                    int numberOfImagesToPick = Math.Min(5, allFiles.Length);
                    var selectedFiles = allFiles.OrderBy(x => rand.Next()).Take(numberOfImagesToPick).ToArray();

                    string selectedImagePath = selectedFiles[rand.Next(selectedFiles.Length)];

                    try
                    {
                        Console.WriteLine($"Attempting to load image: {selectedImagePath}");

                        if (this.BackgroundImage != null)
                        {
                            this.BackgroundImage.Dispose(); // تحرير الصورة القديمة
                        }

                        this.BackgroundImage = Image.FromFile(selectedImagePath);
                        this.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error loading image {selectedImagePath}: {ex.Message}");
                        MessageBox.Show($"Error loading image: {selectedImagePath}\n{ex.Message}");
                    }
                    catch (OutOfMemoryException)
                    {
                        Console.WriteLine($"Out of memory when loading image: {selectedImagePath}");
                        MessageBox.Show("Out of memory when loading image: " + selectedImagePath);
                    }
                }
            }
            else
            {
                MessageBox.Show("مجلد الصور غير موجود. يرجى التأكد من وجوده.");
            }
        }

        private void LoadMusicFiles()
        {
            string musicFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Music");

            if (Directory.Exists(musicFolderPath))
            {
                // Randomly select up to 5 music files
                var selectedFiles = Directory.GetFiles(musicFolderPath, "*.wav")
                                             .OrderBy(_ => Guid.NewGuid())
                                             .Take(2) // Load only a subset of files
                                             .ToList();

                musicFiles.AddRange(selectedFiles);
            }
            else
            {
                MessageBox.Show("Music folder is missing. Please ensure it exists.");
            }
        }

        private void PlayRandomMusic()
        {
            if (musicFiles.Count > 0)
            {
                // Pick a random music file from the subset
                string selectedMusicFile = musicFiles[rand.Next(musicFiles.Count)];

                if (player != null)
                {
                    player.Stop();
                    player.Dispose();
                }

                player = new SoundPlayer(selectedMusicFile);
                player.PlayLooping();
            }
        }


        private void BreakForm_Resize(object sender, EventArgs e)
        {
            if (lblCountdownTimer != null)
            {
                lblCountdownTimer.Location = new Point(
                    (this.ClientSize.Width - lblCountdownTimer.Width) / 2,
                    (this.ClientSize.Height - lblCountdownTimer.Height) / 3
                );
            }

            if (lblQuote != null)
            {
                lblQuote.Location = new Point(
                    (this.ClientSize.Width - lblQuote.Width) / 2,
                    lblCountdownTimer.Bottom + 20
                );
            }

            if (progressBar != null)
            {
                progressBar.Location = new Point(
                    (this.ClientSize.Width - progressBar.Width) / 2,
                    lblQuote.Bottom + 20
                );
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Hide the cursor
            Cursor.Hide();
            Cursor.Clip = this.Bounds;

            // Install the keyboard hook
            keyboardHook = new KeyboardHook();
            keyboardHook.Install();

            // Call the resize event handler to initially center elements
            BreakForm_Resize(this, EventArgs.Empty);

            // استدعاء الدالة وتحديد قيمة نصف القطر
            ApplyRoundedCorners(lblCountdownTimer, 30); // 30 هو نصف قطر الحواف الدائرية
            ApplyRoundedCorners(lblQuote, 30); // 30 هو نصف قطر الحواف الدائرية
        }

        private void ParticleTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                float currentTime = (float)stopwatch.Elapsed.TotalSeconds;
                float deltaTime = currentTime - lastFrameTime;
                lastFrameTime = currentTime;

                // Update particles
                UpdateParticles(deltaTime);

                // Invalidate only the area where particles are drawn
                Rectangle particleArea = new Rectangle(0, 0, this.Width, this.Height);
                this.Invalidate(particleArea, false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception in ParticleTimer_Tick: {ex.Message}");
                // Optionally, stop the timer to prevent further issues
                particleTimer.Stop();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                // Prevent the form from being closed by the user
                e.Cancel = true;
            }
            else
            {
                // Show the cursor
                Cursor.Show();
                Cursor.Clip = Rectangle.Empty;

                // Uninstall the keyboard hook
                keyboardHook.Uninstall();

                // Stop the music
                if (player != null)
                {
                    player.Stop();
                    player.Dispose();
                }

                // Stop the particle timer
                if (particleTimer != null)
                {
                    particleTimer.Stop();
                    particleTimer.Dispose();
                }

                // Stop the stopwatch
                if (stopwatch != null)
                {
                    stopwatch.Stop();
                }

                base.OnFormClosing(e); // Allow the form to close
            }
        }

        public void StartBreak(int seconds)
        {
            breakSeconds = seconds;
            totalBreakSeconds = seconds; // Keep track of the total duration
            UpdateTimerLabel();
            UpdateProgressBar();

            // Start the timer if not already started
            if (!this.timerBreak.Enabled)
                this.timerBreak.Start();
        }

        private void UpdateTimerLabel()
        {
            int minutes = breakSeconds / 60;
            int seconds = breakSeconds % 60;
            lblCountdownTimer.Text = $"{minutes:D2}:{seconds:D2}";
        }

        private void timerBreak_Tick(object sender, EventArgs e)
        {
            if (breakSeconds > 0)
            {
                breakSeconds--;
                UpdateTimerLabel();
                UpdateProgressBar();
            }
            else
            {
                this.timerBreak.Stop();
                allowClose = true;
                this.Close();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.Q))
            {
                allowClose = true;
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void InitializeTimerLabel()
        {
            lblCountdownTimer = new Label();
            lblCountdownTimer.AutoSize = false;
            lblCountdownTimer.Size = new Size(800, 200);
            lblCountdownTimer.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            lblCountdownTimer.ForeColor = Color.White;
            lblCountdownTimer.TextAlign = ContentAlignment.MiddleCenter;
            //lblCountdownTimer.BackColor = Color.Transparent;
            //lblCountdownTimer.BackColor = Color.FromArgb(128);
            lblCountdownTimer.BackColor = Color.FromArgb(76, Color.Black); // قيمة 128 تعني شفافية بنسبة 50%


            // تعيين الموقع بعد معرفة حجم النموذج
            lblCountdownTimer.Location = new Point(
                (this.ClientSize.Width - lblCountdownTimer.Width) / 2,
                (this.ClientSize.Height - lblCountdownTimer.Height) / 3
            );

            this.Controls.Add(lblCountdownTimer);
        }

        private void InitializeQuoteLabel()
        {
            lblQuote = new Label();
            lblQuote.AutoSize = false;
            lblQuote.Size = new Size(1000, 100);
            lblQuote.Font = new Font("Segoe UI", 24F, FontStyle.Italic);
            lblQuote.ForeColor = Color.White;
            lblQuote.TextAlign = ContentAlignment.MiddleCenter;
            //lblQuote.BackColor = Color.Transparent;
            lblQuote.BackColor = Color.FromArgb(76, Color.Black);
            //100 % شفاف: 0
            //90 % شفاف: 25
            //80 % شفاف: 51
            //70 % شفاف: 76
            //60 % شفاف: 102
            //50 % شفاف: 128(كما استخدمنا سابقًا)
            //40 % شفاف: 153
            //30 % شفاف: 179
            //20 % شفاف: 204
            //10 % شفاف: 230
            //0 % شفاف(غير شفاف بالكامل): 255
            // تعيين الموقع بعد إعداد lblCountdownTimer
            lblQuote.Location = new Point(
                (this.ClientSize.Width - lblQuote.Width) / 2,
                lblCountdownTimer.Bottom + 20
            );

            this.Controls.Add(lblQuote);

            // اختيار اقتباس عشوائي
            Random rand = new Random();
            int index = rand.Next(motivationalQuotes.Count);
            lblQuote.Text = motivationalQuotes[index];
        }

        private void InitializeProgressBar()
        {
            progressBar = new CircularProgressBar();
            progressBar.Size = new Size(300, 300);
            progressBar.BackColor = Color.Transparent;

            // تعيين الموقع بعد إعداد lblQuote
            progressBar.Location = new Point(
                (this.ClientSize.Width - progressBar.Width) / 2,
                lblQuote.Bottom + 20
            );

            this.Controls.Add(progressBar);
        }

        private void InitializeParticleSystem()
        {
            // If not already initialized in OnLoad
            stopwatch = new Stopwatch();
            stopwatch.Start();

            particleTimer = new Timer();
            particleTimer.Interval = 16; // Approximately 60 FPS
            particleTimer.Tick += ParticleTimer_Tick;
            particleTimer.Start();
        }

        private void UpdateProgressBar()
        {
            progressBar.Progress = (int)(((double)(totalBreakSeconds - breakSeconds) / totalBreakSeconds) * 100);
            progressBar.Invalidate(); // Force the control to repaint
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw particles
            DrawParticles(e.Graphics);

            // ... existing gradient overlay code ...
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle, Color.FromArgb(50, Color.Black), Color.Transparent, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void DrawParticles(Graphics g)
        {
            foreach (var particle in particles)
            {
                // Skip particles with no remaining life
                if (particle.Life <= 0)
                    continue;

                using (SolidBrush brush = new SolidBrush(particle.Color))
                {
                    float x = particle.Position.X - particle.Size / 2;
                    float y = particle.Position.Y - particle.Size / 2;
                    g.FillEllipse(brush, x, y, particle.Size, particle.Size);
                }
            }
        }

        private void UpdateParticles(float deltaTime)
        {
            // Add new particles if below the maximum limit
            if (particles.Count < maxParticles)
            {
                AddParticles();
            }

            // Update existing particles
            for (int i = particles.Count - 1; i >= 0; i--)
            {
                particles[i].Update(deltaTime);

                // Remove particles that have expired
                if (particles[i].Life <= 0)
                {
                    particles.RemoveAt(i);
                }
            }
            // Log particle count
            Debug.WriteLine($"Particle Count: {particles.Count}");
        }

        private void AddParticles()
        {
            // Generate particles at a reduced rate
            int particlesToAdd = 1; // Reduce the number of particles added per frame

            for (int i = 0; i < particlesToAdd; i++)
            {
                // Generate random position at the bottom of the form
                float x = (float)(rand.NextDouble() * this.Width);
                float y = this.Height + 10; // Start slightly off-screen

                particles.Add(new Particle(new PointF(x, y)));
            }
        }

        private void ApplyRoundedCorners(Label label, int radius)
        {
            // إنشاء مسار بياني دائري لحواف العنصر
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(label.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(label.Width - radius, label.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, label.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            // تعيين المسار كمنطقة القص للعنصر لعمل الحواف الدائرية
            label.Region = new Region(path);
        }
    }
}