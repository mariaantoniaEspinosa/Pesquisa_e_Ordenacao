void pente (List<int> lista)
{
    int i, tmp, dist = lista.size();
    bool houveTroca;

    do
    {
        dist = (int) dist/ 1.3;
        if(dist < 1)
        {
            dist = 1;
        }
        houveTroca = false;
        for(int i = 0; i + dist < lista.size(); i++)
        {
            if(lista[i] > lista[i + dist])
            {
                houveTroca = true;
                tmp = lista[i];
                lista[i] = lista[i + dist];
                lista[i + dist] = tmp;
            }
        }
       
    } while (dist > 1 || houveTroca);

}