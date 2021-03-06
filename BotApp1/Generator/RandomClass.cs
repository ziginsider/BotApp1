﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BotApp1.Generator
{
    public class RandomClass
    {
        #region List of Olya
        public List<string> listOlyaGabe_1 = new List<string> { "грошы", "пральны парашок", "патэльня", "прыгожыя завушніцы", "прас", "рондаль", "кватэра",
                                                                "што-небудзь прыемнае", "зорка на небе", "добрая канапа", "нешта для дзяцей", "карціна Пiкаса",
                                                                "мэбля XVI стагодзя", "вершы Рыгора Барадуліна", "яхта", "калейдаскоп", "кампазіцыя з жывых кветак",
                                                                "кававы набор", "вышыўка на заказ", "стыльная біжутэрыя ручной працы", "Карціны для жанчын з крышталяў Swarovsky",
                                                                "Аксэсуары для ваннай пакоі", "залатыя упрыгожванні", "набор: чайнік гліняны з некалькімі кубкамі і ўпакоўкай смачнай элітнай гарбаты",
                                                                "аплачаныя 10 сеансаў масажу", "скураныя пальчаткі і прыгожы шалік", "паштоўкі, зробленыя сваімі рукамі",
                                                                "дыяменты", "паездка ў Італію", "адпачынак на дзень ці два ў высакакласным гатэлі", "вялізны букет руж",
                                                                "змантаваны фільм з фатаграфій пад яе любімыя песні", "партрэт на заказ", "статуэтка пацешных жывёл",
                                                                "скрабы для цела і твару", "увільгатняльнік або іянізатар паветра", "упрыгожваньні з срэбра", "ваза дэкаратыўная",
                                                                "дэкаратыўныя упрыгожванні для дома", "антыкварыят", "мяккія цацкі", "музычная падушка", "вельмі шмат паветраных шароў",
                                                                "прыгожыя заколкі для валасоў", "аўтаматычныя зубныя шчоткі", "генеалагічнае дрэва", "хатні фантан",
                                                                "прыгожы фірмовы кашалёк з парай тройкай зялёных паперак", "мабільны тэлефон з пакемонамі", "наварочаны штодзённік",
                                                                "набор для фондю", "аксэсуары для кухні", "пацешныя формачкі для лёду", "кніга з рэцэптамі", "фотаальбом з цікавым афармленнем",
                                                                "фарфоравыя статуэткі", "букеты з цукерак", "рэпрадукцыя вядомай карціны", "фарфоравая лялька", "наборы для сушы",
                                                                "танцуючыя кветкі і цацкі Flip Flap", "незвычайныя прысмакі", "жывыя кветачкі ў збанку", "парфумерныя падарункі",
                                                                "сметніца з садавінай", "свечкі незвычайнай формы", "стыльны пясочны гадзіннік", "прыгожы і незвычайны парасон",
                                                                "тры сіямскіх коткі", "рэмень(абавязкова каб ад моднага брэнда)", "сонцаахоўныя акуляры", "«Дамская» мышка для кампутара",
                                                                "скрыначкі для упрыгожванняў", "кнігі па вышэйшай матэматыцы", "солевыя лямпы ці падсвечнікі", "паход ў самы модны SPA-салон",
                                                                "паездка на мора", "прагулка на вярблюдзе", "кавалачак горнага крышталя", "соль для ваннай у выглядзе кветак",
                                                                "падарожжа на Корсіку", "падарожжа ў Iсландыю", "дарагі лікёр", "дарагі парфюм", "торт з фатаграфіяй",
                                                                "бінокль тэатральны", "веер", "аўтарская біжутэрыя", "экзатычнае расліна ў гаршэчку, абавязкова з інструкцыяй",
                                                                "этнічныя штучкі", "старадаўнія кнігі", "Пеця", "дэкаратыўныя аўтарскія лялькі", "абанемент у салярый",
                                                                "ракеткі і валаны для бадмінтона", "ласты, маска, шапачка і акуляры для плавання", "добрыя калготкі",
                                                                "падвеска або брошка на сумку",  "бірулька для ключоў", "канапавыя падушкі з афармленнем вышыўкай",
                                                                "лічбавы фотаапарат", "квіткі на спектакль \"Пінская шляхта\"", "мяккія тапачкі з «вушамі, мордамі, вачамі»",
                                                                "10-50 кг марожанага, а ў прыдачу пару кіло здобных булачак", "10 кг морквы сырой і 3 літры кефіру",
                                                                "кветкі і любоў", "паход у рэстаран", "арома-мыла", "маленькі сабачка", "падстаўка для кольцаў",
                                                                "элегантны набор пасцельнай бялізны", "мусы і гелі для валасоў", "дарагая туш для павек",
                                                                "кветкі", "фільмы пра Рэмба", "пяцігадовая падпіска на СБ", "парабалічная антэна з адмысловым пакетам спартыўных каналаў",
                                                                "дапаможнік па рамонце тэхнікі", "што-небудзь для Алі і Магдалены", "прывітанне з Забашавічаў",
                                                                "збонік вершаў Васіля Быкава", "модныя панчохі", "беларуска-кітайскі слоўнік", "акіян радасці",
                                                                "95 тэзісаў Мартына Лютэра", "кросны", "хлебапечка", "валенкі", "скура жырафы", "green-card", "нешта вельмі прыемнае",
                                                                "тое, што любіць Оля", "Міколавы пераклад Быкава", "шчырае сяброўства", "кампутарная гульня The Sms",
                                                                "квіткі на воднае пола", "Alfa Romeo Berlinetta 1938 года", "сцэнка ад лялечнікаў", "саламяны капялюш",
                                                                "прыгожыя вокладкі для кніг", "тэрмас", "спартыўны ровар", "самавар", "квіткі ў філармонію", "электроннае піяніна",
                                                                "санкі", "10 кг шакаладу", "home decor", "шаўковы дыван", "100 кг цукру", "штосьці смачнае", "тое, што не шкада", "набор да пікніка",
                                                                "сем тысяч даляраў", "100 літраў бярозавага соку", "фіранкі прыгожыя", "парсючок на гадаванне", "джакузi", "кошык па грыбы хадзіць"};

        public List<string> listOlyaGabe_2 = new List<string> { "грошы", "пральны парашок", "патэльню", "прыгожыя завушніцы", "прас", "рондаль", "кватэру",
                                                                "што-небудзь прыемнае", "зорку на небе", "добрую канапу", "нешта для дзяцей", "карціну Пiкаса",
                                                                "мэблю XVI стагодзя", "вершы Рыгора Барадуліна", "яхту", "калейдаскоп", "кампазіцыю з жывых кветак",
                                                                "кававы набор", "вышыўку на заказ", "стыльную біжутэрыю ручной працы", "Карціну для жанчын з крышталяў Swarovsky",
                                                                "Аксэсуары для ваннай пакоі", "залатыя упрыгожванні", "набор: чайнік гліняны з некалькімі кубкамі і ўпакоўкай смачнай элітнай гарбаты",
                                                                "аплачаныя 10 сеансаў масажу", "скураныя пальчаткі і прыгожы шалік", "паштоўкі, зробленыя сваімі рукамі",
                                                                "дыяменты", "паездку ў Італію", "адпачынак на дзень ці два ў высакакласным гатэлі", "вялізны букет руж",
                                                                "змантаваны фільм з фатаграфій пад яе любімыя песні", "партрэт на заказ", "статуэтку пацешных жывёл",
                                                                "скрабы для цела і твару", "увільгатняльнік або іянізатар паветра", "упрыгожваньні з срэбра", "вазу дэкаратыўную",
                                                                "дэкаратыўныя упрыгожванні для дома", "антыкварыят", "мяккія цацкі", "музычная падушка", "вельмі шмат паветраных шароў",
                                                                "прыгожыя заколкі для валасоў", "аўтаматычныя зубныя шчоткі", "генеалагічнае дрэва", "хатні фантан",
                                                                "прыгожы фірмовы кашалёк з парай тройкай зялёных паперак", "мабільны тэлефон з пакемонамі", "наварочаны штодзённік",
                                                                "набор для фондю", "аксэсуары для кухні", "пацешныя формачкі для лёду", "кнігу з рэцэптамі", "фотаальбом з цікавым афармленнем",
                                                                "фарфоравыя статуэткі", "букеты з цукерак", "рэпрадукцыю вядомай карціны", "фарфоравую ляльку", "наборы для сушы",
                                                                "танцуючыю кветку і цацкі Flip Flap", "незвычайную прысмаку", "жывую кветачку ў збанку", "парфумерны падарунак",
                                                                "сметніцу з садавінай", "свечку незвычайнай формы", "стыльны пясочны гадзіннік", "прыгожы і незвычайны парасон",
                                                                "тры сіямскіх коткі", "рэмень(абавязкова каб ад моднага брэнда)", "сонцаахоўныя акуляры", "«Дамскую» мышку для кампутара",
                                                                "скрыначку для упрыгожванняў", "кнігі па вышэйшай матэматыцы", "солевыя лямпы ці падсвечнікі", "паход ў самы модны SPA-салон",
                                                                "паездку на мора", "прагулка на вярблюдзе", "кавалачак горнага крышталя", "соль для ваннай у выглядзе кветак",
                                                                "падарожжа на Корсіку", "падарожжа ў Iсландыю", "дарагі лікёр", "дарагі парфюм", "торт з фатаграфіяй",
                                                                "бінокль тэатральны", "веер", "аўтарская біжутэрыю", "экзатычную расліну ў гаршэчку, абавязкова з інструкцыяй",
                                                                "этнічную рэч (вышыванку, дапрыкладу)", "старадаўнюю кнігу", "Пецю", "дэкаратыўную аўтарскую ляльку", "абанемент у салярый",
                                                                "ракетку і валаны для бадмінтона", "ласты, маску, шапачку і акуляры для плавання", "добрыя калготкі",
                                                                "падвеску або брошку на сумку",  "бірульку для ключоў", "канапавую падушку з афармленнем вышыўкай",
                                                                "лічбавы фотаапарат", "квіткі на спектакль \"Пінская шляхта\"", "мяккія тапачкі з «вушамі, мордамі, вачамі»",
                                                                "10-50 кг марожанага, а ў прыдачу пару кіло здобных булачак", "10 кг морквы сырой і 3 літры кефіру",
                                                                "кветкі і любоў", "паход у рэстаран", "арома-мыла", "маленькую сабачку", "падстаўку для кольцаў",
                                                                "элегантны набор пасцельнай бялізны", "мусы і гелі для валасоў", "дарагую туш для павек",
                                                                "кветкі", "фільмы пра Рэмба", "пяцігадовую падпіску на СБ", "парабалічную антэну з адмысловым пакетам спартыўных каналаў",
                                                                "дапаможнік па рамонце тэхнікі", "што-небудзь для Алі і Магдалены", "прывітанне з Забашавічаў",
                                                                "збонік вершаў Васіля Быкава", "модныя панчохі", "беларуска-кітайскі слоўнік", "акіян радасці",
                                                                "95 тэзісаў Мартына Лютэра", "кросны", "хлебапечку", "валенкі", "скуру жырафы", "green-card", "нешта вельмі прыемнае",
                                                                "тое, што любіць Оля", "Міколавы пераклад Быкава", "шчырае сяброўства", "кампутарную гульню The Sims",
                                                                "квіткі на воднае пола", "Alfa Romeo Berlinetta 1938 года", "сцэнку ад лялечнікаў", "саламяны капялюш",
                                                                "прыгожыя вокладкі для кніг", "тэрмас", "спартыўны ровар", "самавар", "квіткі ў філармонію", "электроннае піяніна",
                                                                "санкі", "10 кг шакаладу", "home decor", "шаўковы дыван", "100 кг цукру", "штосьці смачнае", "тое, што не шкада", "набор да пікніка",
                                                                "сем тысяч даляраў", "100 літраў бярозавага соку", "фіранкі прыгожыя", "парсючка на гадаванне", "джакузi", "кошык па грыбы хадзіць"};
        #endregion
        #region List of Predicat Predicat
        public List<string> listGabePredicatPredicat_1 = new List<string> {"Ну што падарыць? ", "Зараз, трошкі падумаю... ", "Добра, што мяне запыталіся, бо я майстра ў падарунках. Дык вось. ",
                                                                "Трэба падумаць... ", "Які падарунак пытаеце? ", "Да падарункаў трэба з розумам пыходзіць, а не абы як! ",
                                                                "Хм... Нешта не ідзе ў галаву нічога.. А! Вось. ", "Дык усё што заўгодна можна падарыць, але ж... ",
                                                                "Добрае пытанне! I па адрасу. Толькі я ведаю, што патрэбна дарыць жанчынам. ", "Зараз адкажу... ", " ", " ", " "};
        #endregion
        #region List of Predicat
        public List<string> listGabePredicat_1 = new List<string> {"Я ведаю, што добры падарунак - гэта ", "Сапраўдны падарунак гэта ", "Добры падарунак для Олі гэта ", "Я думаю, што трэба падарыць такую рэч... Ну, карацей, гэта  ",
                                                                    "Мне здаецца, што добры падарунак вось што:  ", "Мне здаецца, што падыйдзе вось што: ", "Мне здаецца, што сапраўдны падарунак гэта ",
                                                                    "Самы лепшы ў свеце падарунак для дзяўчыны гэта ",  "Самы лепшы ў свеце падарунак, канечне, гэта ", "Я мяркую, што Оля не адмовіцца, калі падарунак будзе ",
                                                                    "Штосьці мне падказвае, што Оля не адмовіцца, калі падарункам будзе ",
                                                                    "Я упэўнены, што Оля будзе вельмі рада, калі яна, зніме ўпакоўку і ўбачыць, што там ", "Оля мне казала, што хоча толькі адну рэч. I гэта ",
                                                                    "Оле патрэбна адное. Гэта ", "Оле вельмі зараз не хапае аднаго. I чаго ж вы думалі? Не ведаеце? А гэта усяго толькі ",
                                                                    "Я б дарыў толькі адное. I гэта "};
        public List<string> listGabePredicat_2 = new List<string> {"Мая прабабка казала, што раней (а было то 80 год таму) яны дарылі адзін аднаму ",
                                                                    "Мой прадзед казаў, што раней (а было то 80 год таму) яны дарылі адзін аднаму ",
                                                                    "Мая прабабка казала, што раней (а было то 80 год таму) яны дарылі сваім сябрам ",
                                                                    "Мой прадзед казаў, што раней (а было то 80 год таму) яны дарылі сваім сябрам ",
                                                                    "Мая прабабка казала, што раней (а было то 80 год таму) яны дарылі сваім сябрам ",
                                                                    "Мой прадзед казаў, што раней (а было то 80 год таму) яны дарылі сваім сябрам ",
                                                                    "Мая прабабка казала, што раней (а было то 80 год таму) добраму чалавеку дарылі ",
                                                                    "Мой прадзед казаў, што раней (а было то 80 год таму) добраму чалавеку дарылі ",
                                                                    "Я ведаю, што добры падарунак будзе, калі мы падорым ", "Давайце падорым ёй ", "Што падарыць для Олі? Падорым ", "Я думаю, што трэба падарыць ",
                                                                    "Мне здаецца, што была б добра падараваць ", "А давайце купім для яе ", "Мне здаецца, што трэба дарыць ",
                                                                    "А давайце, давайце, давайце падорым ",  "Самым лепшым будзе падараваць ", "Я мяркую, што Оля не адмовіцца, калі мы падорым ёй ",
                                                                    "Штосьці мне падказвае, што Оля не адмовіцца, калі падаруем ",
                                                                    "Я упэўнены, што Оля будзе вельмі рада, калі яна, зніме ўпакоўку і ўбачыць, што падаравалі ", "Оля мне казала, што хоча толькі адну рэч. Якую? ",
                                                                    "Оле патрэбна адное. Купім ёй ", "Оле вельмі зараз не хапае аднаго. Яна марыць каб атрымаць ",
                                                                    "Я б дарыў толькі адное: ", "Слухай мой загад! Оля атрымае ў падарунак "};
        #endregion
        #region List of Postdicat
        public List<string> listGabePostdicat_1 = new List<string> {"Гэта лепшае, што можна прыдумаць!", "Ці вы не згодны?", "Я маю рацыю!", " ", " ", "Ці хтосьці можа прапанаваць лепшае?",
                                                                    "I гэта сапраўды патрэбна!","Ну? Ці я не правы?", "Я ведаю, што кажу.", "Вось як! Дрэннага не параю.",
                                                                    "Вось як! Толькі лепшыя парады. Звяртайцеся!", "Iдэя на мільён!",
                                                                    "Ну, як вам ідэя? Бачу, што спадабалася. Як у нас гавораць: баба з возу, каню лягчэй!",
                                                                    "Хто можа прапанаваць што лепшае?", "Калі што, звяртайцеся.", "Што скажыце?", "Ну, як ідэйка?", "Што? Думаеце гэта не падыйдзе?",
                                                                    "Што? Думаеце гэта не падыйдзе? Гэта Мікола насамрэч мне падказаў. Яго ідэя.", "Ну, што браты скажуць на гэта?",
                                                                    "Спадабалася ідэя? 100 адсодкаў!", "I гэта маё апошняе слова.", "Як мая прапанова? Штосьці не чую апладысментаў.",
                                                                    "Ну вось! Па вашых тварах бачу, што не спадабалася мая прапанова..",
                                                                    "Ну вось! Па вашых тварах бачу, што не спадабалася прапанова.. Але ж, насамрэч, гэта Юля Хумала мне падказала.",
                                                                    "А! Як? Добрая ідэя. Анягож!", "Добрая ідэя? Анягож. Гэта Лёша Рассыльны мне падказаў.",
                                                                    "I чыя вы думаеце гэта ідэя? У Лены Хадасевіч узяў", "P.S. Iдэя не мая. Пан Кісель падказаў.", "P.S. Iдэя не мая. Мікола падказаў.",
                                                                    " ", "P.S. Iдэя не мая. Узята ў Машы Маляўкі", "Калі што, спачатку тое ж і Вераніка прапаноўвала.", "Люблю сябе за такія знаходкі!",
                                                                    "Памятаю, тое ж і Таня Робак прапаноўвала.", "Ці я ж не разумнічка за такія ідэі?", "Тое, што сапраўды патрэбна для жанчыны.",
                                                                    "Ох і падабаецца мне мая прапанова!", "Iдэю ў Юлі скраў", "Насамрэч, гэта Маша мне па сакрэце падказала. Яна ведае, што патрэбна.",
                                                                    "Скажу па сакрэце, гэта ідэя Лёшы Рассыльнага", "Між намі: Оля казала, што тое і хоча.", " ", " ", " ", ":)",
                                                                    "))))))))", "))", "8)", "))))))))))))))"};
        #endregion

        #region Func of All
        static IEnumerable<int> Generator(int max)
        {
            Random r = new Random();
            while(true)
            {
                yield return r.Next(max);
            }
        }

        public string GetStrNumbers(int max, int count)
        {
            int var = 0;
            string str = "";
            foreach(var item in Generator(max).Take(count))
            {
                var = item;
                str += var.ToString() + " ";
            }
            return str;
            
        }

        public int GetIntNumber(int max)
        {
            Random r = new Random();
            return r.Next(0, max);
        }

        private async Task<string> GetRandomElement(List<string> list)
        {
            Random r = new Random();
            return list[r.Next(0, list.Count())];
        }
        #endregion
        #region Func of 1 -> imenitelnyi
        public async Task<string> GetOlyaGabe_1()
        {
            return await GetRandomElement(listOlyaGabe_1);
        }

        public async Task<string> GetPredicateGabe_1()
        {
            var result1 = await GetRandomElement(listGabePredicatPredicat_1);
            var result2 = await GetRandomElement(listGabePredicat_1);
            return (result1 + result2);
        }

        public async Task<string> GetPostdicatGabe_1()
        {
            return await GetRandomElement(listGabePostdicat_1);
        }

        public async Task<string> GetResultOlyaGabe_1()
        {
            var result = await GetPredicateGabe_1() + await GetOlyaGabe_1() + ". " + await GetPostdicatGabe_1();
            return result;
        }
        #endregion
        #region Func of 2 -> Vinitelnyi
        public async Task<string> GetOlyaGabe_2()
        {
            return await GetRandomElement(listOlyaGabe_2);
        }

        public async Task<string> GetPredicateGabe_2()
        {
            var result1 = await GetRandomElement(listGabePredicatPredicat_1);
            var result2 = await GetRandomElement(listGabePredicat_2);
            return (result1 + result2);
        }
        public async Task<string> GetResultOlyaGabe_2()
        {
            var result = await GetPredicateGabe_2() + await GetOlyaGabe_2() + ". " + await GetPostdicatGabe_1();
            return result;
        }
        #endregion

    }
}