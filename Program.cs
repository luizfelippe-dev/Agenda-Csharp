int pontuacao = 0;

    //Pergunta1
    Console.WriteLine("Quanto é 5+5?"+" Escreva sua resposta abaixo");
        int resposta_1 = int.Parse(Console.ReadLine());

            if(resposta_1 == 10)
                {
                    pontuacao++;
                }
    //Pergunta2    
    Console.WriteLine("Quanto é 10+5?"+" Escreva sua resposta abaixo");
        int resposta_2 = Convert.ToInt32(Console.ReadLine());

            if(resposta_2 == 15)
                {
                    pontuacao++;
                }
    //Pergunta3            
    Console.WriteLine("Quem é o CEO da Danki Code?"+" Escreva Sua Resposta:");
        string resposta_3 = Console.ReadLine();

            if(resposta_3 == "Guilherme")
            {
                pontuacao++;
            }            
    //Pergunta4        
                Console.WriteLine("Quem é o instrutor do curso de C# da Danki Code?"+" Escreva Sua Resposta:");
        string resposta_4 = Console.ReadLine();

            if(resposta_4 == "Moisés")
            {
                pontuacao++;
            }            

            //Pontuação Total
            Console.WriteLine("O seu total de Pontos Foi: "+ pontuacao);