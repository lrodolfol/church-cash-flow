# Backend Church - Tesouraria e Secretaria (em desenvolvimento)

API do churchManage. CRUD de operações para secretaria e tesouraria com:
Igrejas, membros, ofertas, cultos, primicias, dizimos, cargos, serviços e fechamento mensal.

Autenticação e autorização para uso dos endpoints baseado nos cargos de secretario e tesoureiro.


## Diagrama completo
![Diagrama](https://raw.githubusercontent.com/lrodolfol/church-cash-flow/refs/heads/main/Registration/diagrama.png)


## Documentação
[Documentação em modo debug] - (http://localhost:8181/swagger/index.html)

## Rodando esteira completa em containers: 
```
version: '3.4'

services:
  churchmanager:
    container_name: churchmanager-uat
    image: rodolfojesus/church-manager:latest
    command: dotnet run
    ports:
      - 7171:8181
    environment:
      - ASPNETCORE_ENVIRONMENT=uat
      - KEYUSERCREATED=AAECAwQFBgcICQoUAT0ODw==
      - PASSEMAIL=#senhaforte123
      - AWS_ACCESS_KEY_ID=****
      - AWS_SECRET_ACCESS_KEY=***
      - AWS_SESSION_TOKEN=your_session_token
    depends_on:
      - churchmanagerdb
      - rabbitDocker-uat
    networks:
      - netchurchmanager

  consume-new-user-created:
    container_name: consume-new-user-created-uat
    image: rodolfojesus/church-consume-user-created:latest
    environment:
      RABBITMQ_HOST: rabbitDocker-uat
      RABBITMQ_USERNAME: sinqia
      RABBITMQ_PASSWORD: sinqia123
      RABBITMQ_PORT: 5672
      AWSSecretKey: "***"
      AWSAccessKey: "***"
    depends_on:
      - rabbitDocker-uat
    networks:
      - netchurchmanager

  angular-app:
    container_name: church-front
    image: rodolfojesus/church-front
    command: ng serve --host 0.0.0.0
    ports:
      - "4200:4200"
    environment:
      - NODE_ENV=production
    depends_on:
      - churchmanagerdb
      - rabbitDocker-uat
    networks:
      - netchurchmanager
      
  mongodb-bible:
    container_name: mongo
    image: rodolfojesus/mongodb-bible:latest
    environment:
      - MONGO_INITDB_ROOT_USERNAME=mongoadmin
      - MONGO_INITDB_ROOT_PASSWORD=passMongoDb123
    volumes:
      - mongoData:/data/db
    ports:
      - "27017:27017"
    networks:
      - netchurchmanager
    restart: unless-stopped

  churchmanagerdb:
    container_name: churchmanagerdb-uat
    hostname: churchmanagerdb
    image: mysql
    ports:
      - 3308:3306
    environment:
      - MYSQL_ROOT_PASSWORD=sinqia123
      - MYSQL_DATABASE=ChurchCashFlow
    volumes:
      - mysqlData-UAT:/var/lib/mysql
    networks:
      - netchurchmanager

  rabbitDocker-uat:
    container_name: rabbit-uat
    image: rabbitmq:3-management
    ports:
      - 5674:5672
      - 15674:15672
    environment:
      - RABBITMQ_DEFAULT_USER=sinqia
      - RABBITMQ_DEFAULT_PASS=sinqia123
    volumes:
      - rabbitmqData-UAT:/var/lib/rabbitmq
    networks:
      - netchurchmanager

  redis:
    image: redis:latest
    container_name: redis-uat
    ports:
      - "6379:6379"
    environment:
      - REDIS_PASSWORD=sinqia123
    command: redis-server --save 20 1 --loglevel warning --requirepass sinqia123
    restart: unless-stopped
    volumes:
      - redisData-UAT:/data
    networks:
      - netchurchmanager

networks:
  netchurchmanager:
    driver: bridge

volumes:
  mysqlData-UAT:
  rabbitmqData-UAT:
  redisData-UAT:
  mongoData:

```
Ou baixe cada repo nos seus respectivos links: 
<br>C# WebScrap: https://github.com/lrodolfol/Biblie-Filled
<br>Java Consume rabbitmq: https://github.com/lrodolfol/churchManager-ConsumeNewUserCreated
<br>Angular FrontEnd: https://github.com/lrodolfol/church-cash-flow-front
<br>C# Lambda: nesse mesmo repo em ./Serveless


## Autores
- [Rodolfo Jesus - linkedin](https://www.linkedin.com/in/rodolfojesus/)
- [Rodolfo Jesus - email](rodolfo0ti@gmail.com)

