using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class MusicalInstument
    {
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();

    }

    class Violin : MusicalInstument
    {

        public override void Sound()
        {
            Console.WriteLine(" A, A#, B, C, C#, D, D#, E, F, F#, G, G#");
        }
        public override void Show()
        {
            Console.WriteLine("Violin");
        }

        public override void Desc()
        {
            Console.WriteLine("Violin is a stringed musical instrument of treble pitch, played with a horsehair bow. \n" +
                "The classical European violin was developed in the 16th century. It has four strings and a body of characteristic rounded shape,\n" +
                " narrowed at the middle and with two f-shaped soundholes.");
        }

        public override void History()
        {
            Console.WriteLine("The earliest stringed instruments were mostly plucked (for example, the Greek lyre). Two-stringed, bowed instruments, played upright and strung and bowed with horsehair, may have originated in the nomadic equestrian cultures of Central Asia, in forms closely resembling the modern-day Mongolian Morin huur and the Kazakh Kobyz. Similar and variant types were probably disseminated along east–west trading routes from Asia into the Middle East,[9][10] and the Byzantine Empire.[11][12]\r\n\r\nAccording to Encyclopædia Britannica, the direct ancestor of all European bowed instruments is the Arabic rebab (ربابة), which developed into the Byzantine lyra by the 9th century and later the European rebec.[13][14][15][16] Several sources suggest alternative possibilities for the violin's origins, such as northern or western Europe.[17][18][19][20] The first makers of violins probably borrowed from various developments of the Byzantine lyra. These included the vielle (also known as the fidel or viuola) and the lira da braccio.[11][21] The violin in its present form emerged in early 16th-century northern Italy. The earliest pictures of violins, albeit with three strings, are seen in northern Italy around 1530, at around the same time as the words \"violino\" and \"vyollon\" are seen in Italian and French documents. One of the earliest explicit descriptions of the instrument, including its tuning, is from the Epitome musical by Jambe de Fer, published in Lyon in 1556.[22] By this time, the violin had already begun to spread throughout Europe.\r\n\r\nThe violin proved very popular, both among street musicians and the nobility; the French king Charles IX ordered Andrea Amati to construct 24 violins for him in 1560.[23] One of these \"noble\" instruments, the Charles IX, is the oldest surviving violin. The finest Renaissance carved and decorated violin in the world is the Gasparo da Salò (c.1574) owned by Ferdinand II, Archduke of Austria and later, from 1841, by the Norwegian virtuoso Ole Bull, who used it for forty years and thousands of concerts, for its very powerful and beautiful tone, similar to that of a Guarneri.[24] \"The Messiah\" or \"Le Messie\" (also known as the \"Salabue\") made by Antonio Stradivari in 1716 remains pristine. It is now located in the Ashmolean Museum of Oxford.[25]");
        }
    }


    class Trombone : MusicalInstument
    {

        public override void Sound()
        {
            Console.WriteLine(" A, A#, B, C, C#, D, D#, E, F, F#, G, G#");

        }
        public override void Show()
        {
            Console.WriteLine("Trombone");
        }

        public override void Desc()
        {
            Console.WriteLine("Trombone a brass instrument consisting of a long cylindrical metal tube with two turns and having a movable slide or valves for varying the tone and a usual range one octave lower than that of the trumpet.");
        }

        public override void History()
        {
            Console.WriteLine("The earliest stringed instruments were mostly plucked (for example, the Greek lyre). Two-stringed, bowed instruments, played upright and strung and bowed with horsehair, may have originated in the nomadic equestrian cultures of Central Asia, in forms closely resembling the modern-day Mongolian Morin huur and the Kazakh Kobyz. Similar and variant types were probably disseminated along east–west trading routes from Asia into the Middle East,[9][10] and the Byzantine Empire.[11][12]\r\n\r\nAccording to Encyclopædia Britannica, the direct ancestor of all European bowed instruments is the Arabic rebab (ربابة), which developed into the Byzantine lyra by the 9th century and later the European rebec.[13][14][15][16] Several sources suggest alternative possibilities for the violin's origins, such as northern or western Europe.[17][18][19][20] The first makers of violins probably borrowed from various developments of the Byzantine lyra. These included the vielle (also known as the fidel or viuola) and the lira da braccio.[11][21] The violin in its present form emerged in early 16th-century northern Italy. The earliest pictures of violins, albeit with three strings, are seen in northern Italy around 1530, at around the same time as the words \"violino\" and \"vyollon\" are seen in Italian and French documents. One of the earliest explicit descriptions of the instrument, including its tuning, is from the Epitome musical by Jambe de Fer, published in Lyon in 1556.[22] By this time, the violin had already begun to spread throughout Europe.\r\n\r\nThe violin proved very popular, both among street musicians and the nobility; the French king Charles IX ordered Andrea Amati to construct 24 violins for him in 1560.[23] One of these \"noble\" instruments, the Charles IX, is the oldest surviving violin. The finest Renaissance carved and decorated violin in the world is the Gasparo da Salò (c.1574) owned by Ferdinand II, Archduke of Austria and later, from 1841, by the Norwegian virtuoso Ole Bull, who used it for forty years and thousands of concerts, for its very powerful and beautiful tone, similar to that of a Guarneri.[24] \"The Messiah\" or \"Le Messie\" (also known as the \"Salabue\") made by Antonio Stradivari in 1716 remains pristine. It is now located in the Ashmolean Museum of Oxford.[25]");
        }
    }

    class Cello : MusicalInstument
    {

        public override void Sound()
        {
            Console.WriteLine(" A, A#, B, C, C#, D, D#, E, F, F#, G, G#");

        }
        public override void Show()
        {
            Console.WriteLine("Cello");
        }

        public override void Desc()
        {
            Console.WriteLine("Trombone a brass instrument consisting of a long cylindrical metal tube with two turns and having a movable slide or valves for varying the tone and a usual range one octave lower than that of the trumpet.");
        }

        public override void History()
        {
            Console.WriteLine("The earliest stringed instruments were mostly plucked (for example, the Greek lyre). Two-stringed, bowed instruments, played upright and strung and bowed with horsehair, may have originated in the nomadic equestrian cultures of Central Asia, in forms closely resembling the modern-day Mongolian Morin huur and the Kazakh Kobyz. Similar and variant types were probably disseminated along east–west trading routes from Asia into the Middle East,[9][10] and the Byzantine Empire.[11][12]\r\n\r\nAccording to Encyclopædia Britannica, the direct ancestor of all European bowed instruments is the Arabic rebab (ربابة), which developed into the Byzantine lyra by the 9th century and later the European rebec.[13][14][15][16] Several sources suggest alternative possibilities for the violin's origins, such as northern or western Europe.[17][18][19][20] The first makers of violins probably borrowed from various developments of the Byzantine lyra. These included the vielle (also known as the fidel or viuola) and the lira da braccio.[11][21] The violin in its present form emerged in early 16th-century northern Italy. The earliest pictures of violins, albeit with three strings, are seen in northern Italy around 1530, at around the same time as the words \"violino\" and \"vyollon\" are seen in Italian and French documents. One of the earliest explicit descriptions of the instrument, including its tuning, is from the Epitome musical by Jambe de Fer, published in Lyon in 1556.[22] By this time, the violin had already begun to spread throughout Europe.\r\n\r\nThe violin proved very popular, both among street musicians and the nobility; the French king Charles IX ordered Andrea Amati to construct 24 violins for him in 1560.[23] One of these \"noble\" instruments, the Charles IX, is the oldest surviving violin. The finest Renaissance carved and decorated violin in the world is the Gasparo da Salò (c.1574) owned by Ferdinand II, Archduke of Austria and later, from 1841, by the Norwegian virtuoso Ole Bull, who used it for forty years and thousands of concerts, for its very powerful and beautiful tone, similar to that of a Guarneri.[24] \"The Messiah\" or \"Le Messie\" (also known as the \"Salabue\") made by Antonio Stradivari in 1716 remains pristine. It is now located in the Ashmolean Museum of Oxford.[25]");
        }
    }
    class Ukulele : MusicalInstument
    {

        public override void Sound()
        {
            Console.WriteLine(" A, A#, B, C, C#, D, D#, E, F, F#, G, G#");

        }
        public override void Show()
        {
            Console.WriteLine("Ukulele");
        }

        public override void Desc()
        {
            Console.WriteLine("Trombone a brass instrument consisting of a long cylindrical metal tube with two turns and having a movable slide or valves for varying the tone and a usual range one octave lower than that of the trumpet.");
        }

        public override void History()
        {
            Console.WriteLine("The earliest stringed instruments were mostly plucked (for example, the Greek lyre). Two-stringed, bowed instruments, played upright and strung and bowed with horsehair, may have originated in the nomadic equestrian cultures of Central Asia, in forms closely resembling the modern-day Mongolian Morin huur and the Kazakh Kobyz. Similar and variant types were probably disseminated along east–west trading routes from Asia into the Middle East,[9][10] and the Byzantine Empire.[11][12]\r\n\r\nAccording to Encyclopædia Britannica, the direct ancestor of all European bowed instruments is the Arabic rebab (ربابة), which developed into the Byzantine lyra by the 9th century and later the European rebec.[13][14][15][16] Several sources suggest alternative possibilities for the violin's origins, such as northern or western Europe.[17][18][19][20] The first makers of violins probably borrowed from various developments of the Byzantine lyra. These included the vielle (also known as the fidel or viuola) and the lira da braccio.[11][21] The violin in its present form emerged in early 16th-century northern Italy. The earliest pictures of violins, albeit with three strings, are seen in northern Italy around 1530, at around the same time as the words \"violino\" and \"vyollon\" are seen in Italian and French documents. One of the earliest explicit descriptions of the instrument, including its tuning, is from the Epitome musical by Jambe de Fer, published in Lyon in 1556.[22] By this time, the violin had already begun to spread throughout Europe.\r\n\r\nThe violin proved very popular, both among street musicians and the nobility; the French king Charles IX ordered Andrea Amati to construct 24 violins for him in 1560.[23] One of these \"noble\" instruments, the Charles IX, is the oldest surviving violin. The finest Renaissance carved and decorated violin in the world is the Gasparo da Salò (c.1574) owned by Ferdinand II, Archduke of Austria and later, from 1841, by the Norwegian virtuoso Ole Bull, who used it for forty years and thousands of concerts, for its very powerful and beautiful tone, similar to that of a Guarneri.[24] \"The Messiah\" or \"Le Messie\" (also known as the \"Salabue\") made by Antonio Stradivari in 1716 remains pristine. It is now located in the Ashmolean Museum of Oxford.[25]");
        }
    }
}
