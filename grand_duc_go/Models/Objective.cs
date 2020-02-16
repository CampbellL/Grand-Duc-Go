using System.Collections.Generic;

namespace grand_duc_go.Models
{
    public class Objective
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Heading { get; set; }
        public string Image { get; set; }
        public bool Unlocked { get; set; }

        public List<Quiz> Quizzes { get; set; }

        public bool NotUnlocked
        {
            get => !Unlocked;
        }

        public bool NotCompleted
        {
            get => !QuizCompleted;
        }

        public bool QuizCompleted { get; set; }

        private static List<Objective> _objectives = new List<Objective>()
        {
            new Objective()
            {
                Heading = "The cliff with Holes", Name = "The Bock", Image = "Hz.png", Unlocked = false,
                Text =
                    "In the year 963, a Count by the name of Siegfried received a caste on a rock spur on the slopes, from the Abbey of St. Maximin of Trier, in exchange for land. Over time the little castle which came to be known as “Lucilinburhuc” began to flourish. The name was passed on to the town that grew around the castle and later to the countryside. From the 12th century onwards, Luxembourg was considered a city, as it became an economic, political and religious centre of the region.",
                QuizCompleted = false, Quizzes = new List<Quiz>()
                {
                    new Quiz
                    {
                        CompletionText = "In the Luxembourgish language “Huelen Zant” means “Hollowed tooth”. Siegfried’s castle Lucilinburhuc was later renamed to Luxembourg. ",
                        Question = "What does the gate remnants resemble?",
                        Answers = new[]
                        {
                            new Answer("A hollowed tooth", true),
                            new Answer("A hollowed-out tree stump", false),
                            new Answer("A work in progress that never got anywhere", false)
                        }
                    },
                    new Quiz
                    {
                        CompletionText = "As the little castle began to flourish. The name was passed on to the town that grew around the castle and eventually to the countryside. This is the origin story of Luxembourg.",
                        Question = "The “Bockfels” is the birthplace of…?",
                        Answers = new[]
                        {
                            new Answer("a myth", false),
                            new Answer("the city of Luxembourg.", true),
                            new Answer("the first duke of Luxembourg", false)
                        }
                    },
                    new Quiz
                    {
                        CompletionText = "An old familiar term for the fortress of Luxembourg is “Gibraltar of the North”.",
                        Question = "What was the fortress know as?",
                        Answers = new[]
                        {
                            new Answer("Siegfried’s Keep", false),
                            new Answer("Howl’s Castle", false),
                            new Answer("Gibraltar of the North", true),
                        },
                    }
                },
            },
            new Objective()
            {
                Heading = "The Duke's Office", Name = "Palais Grand-Ducal", Image = "Palais.png", Unlocked = false,
                QuizCompleted = false, Text = "The Grand Ducal Palace was built in 1574 on top of the old town hall foundation and was used as the city hall of Luxemburg. Since 1890, the Palace is the official residence of the Grand Duke of Luxemburg to exercise his official functions as the head of state. In 1848, the Grand Duke Wilhelm II agreed for a constitutional amendment that replaced the Estates Assembly with a freely elected Chamber of Deputies, which is also physically connected to the palace. Luxembourg’s first parliamentary constitution was one of the most liberal in Europe at the time. The government was changed to be a constitutional monarchy, instead of an absolute monarchy, meaning the parliament co-ruled the country together with the grand duke.",
                Quizzes = new List<Quiz>()
                {
                    new Quiz
                    {
                        CompletionText = "The Flag is raised to indicate that the Duke is in the palace.",
                        Question = "What does the Flag at the palace indicate?",
                        Answers = new[]
                        {
                            new Answer("The duke got mail.", false),
                            new Answer("the grand duke is present.", true),
                            new Answer("a birthday in the duke’s family.", false)
                        }
                    },
                    new Quiz
                    {
                        Question = "Chamber of Deputies is physically connected to the palace.",
                        Answers = new[]
                        {
                            new Answer("the chamber of deputies is directly connected to it.", false),
                            new Answer("It’s made out of cardboard, glue and a lot of imagination.", false),
                            new Answer("it was built using material of the old town hall built in Luxembourg.", true)
                        }
                    },
                    new Quiz
                    {
                        CompletionText = "The government was changed to be a constitutional monarchy, instead of an absolute monarchy, meaning the parliament co-ruled the country together with the grand duke.",
                        Question = "The constitution changed the form of government to…? ",
                                   Answers = new[]
                        {
                            new Answer("a constitutional monarchy", true),
                            new Answer("an absolute monarchy", false),
                            new Answer("a democracy", false)
                        }
                    }
                }
            },
            new Objective()
            {
                Heading = "A cliff with loopholes", Name = "Casemates du Bock", Image = "KM.png", Unlocked = false,
                QuizCompleted = false,
                Text =
                    "The casemates of the City of Luxembourg are caves and passages carved into a brickwork, which serves as a position for cannons and archers. The city’s first casemates were built during the Spanish siege in 1644. The total length of the casemates used to be 23km. The defense system was laid out over several floors and some corridors reached a depth up to 40m. It was a high brickwork, which serves as a position for cannons and archers.",
                Quizzes = new List<Quiz>()
                {
                    new Quiz
                    {
                        CompletionText = "The casemates were constructed in 1644 during the Spanish siege.",
                        Question = "When were the first casemates built?",
                        Answers = new[]
                        {
                            new Answer("1921", false),
                            new Answer("1644", true),
                            new Answer("1378", false)
                        }
                    },
                    new Quiz
                    {
                        CompletionText = "The Spanish constructed the casemates during their siege of the fortress.",
                        Question = "Who built the first casemates?",
                        Answers = new[]
                        {
                            new Answer("Luxembourg", false),
                            new Answer("Germany", false),
                            new Answer("Spain", true)
                        }
                    },
                    new Quiz
                    {
                        CompletionText = "The casemates served as a position for cannons and archers.",
                        Question = "What purpose do the casemates serve? ",
                        Answers = new[]
                        {
                            new Answer("Defense purposes", true),
                            new Answer("Passages for the population to reach the Old Town", false),
                            new Answer("Storage space for the grand ducal family", false)
                        }
                    }
                }
            },
            new Objective()
            {
                Heading = "A high horse", Name = "Place Guillaume II", Image = "GG.png", Unlocked = false,
                QuizCompleted = false, Text = "“Place Guillaume II” is a public square that is named after the second grand duke of Luxembourg. In recognition of his respectability as regent, the bronze equestrian statue was erected. The pedestal of the monument shows the emblems of the House of Orange-Nassau and Luxembourg as well as the twelve cantons of the Grand Duchy. Before being turn into a multipurpose space, the space was the site of a Franciscan monastery. That is why it is also known as „Knuedler“, from the Luxembourgish language’s word “de Knuet”, which means “knot” and refers to the knot in the belt worn by Franciscan friars. The Knuedler (Place Guillaume II) forms the center of the city together with the „Place d’Armes“, which originally served as a parade ground for the troops defending the city. The two public squares are separated from each other only by a passage through the buildings.",
                Quizzes = new List<Quiz>()
                {
                    new Quiz
                    {
                        CompletionText = "Since the middle of the 13th century, the monastery of the Franciscan Order stood on Place Guillaume, which was demolished after 1797 by requisition of the French. ",
                        Question = "What stood in place before the area was turned into a multipurpose square?",
                        Answers = new[]
                        {
                            new Answer("A monastery", true),
                            new Answer("A chapel", false),
                            new Answer("A garden", false)
                        }
                    },
                    new Quiz
                    {
                        CompletionText = "The pedestal of the monument shows the emblems of the House of Orange-Nassau and Luxembourg aswell as the twelve cantons of the Grand Duchy. ",
                        Question = "What is depicted on the pedestal of the monument?",
                        Answers = new[]
                        {
                            new Answer("the 12 cantons of Luxembourg and a grand duke and his wife", true),
                            new Answer("the 12 cantons of Luxembourg and a grand duke and his husband.", false),
                            new Answer("the 10 cantons of Luxembourg and a grand duke and his wife", false)
                        }
                    },
                    new Quiz
                    {
                        CompletionText = "The Franciscan friars used to wear a knotted belt. „Knued“, the Luxembourgish word for knot gave so the name „Knuedler“ to the square.",
                        Question = "What is the alternate name for “Place Guillaume II”?",
                        Answers = new[]
                        {
                            new Answer("Knuedler", true),
                            new Answer("Place d’armes", false),
                            new Answer("Place de l’Etoiles", false)
                        }
                    },
                }
            },
        };

        public static List<Objective> GetObjectives()
        {
            return _objectives;
        }
    }
}