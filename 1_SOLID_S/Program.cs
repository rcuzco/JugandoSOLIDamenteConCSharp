// See https://aka.ms/new-console-template for more information
using SOLID;

Console.WriteLine("Hello, World!");

UserServiceNotSolid userServiceNotSolid = new UserServiceNotSolid();
userServiceNotSolid.Register(email: "rony@mail.com", password: "12345Ciber");

Console.WriteLine("User registered!");


Console.WriteLine("Ahora vamos a hacerlo bien");

EmailService emailService = new EmailService();
EncryptionService encryptionService = new EncryptionService();
UserRespositoryService userRespositoryService = new UserRespositoryService();
CacheService cacheService = new CacheService();

UserService userService = new UserService(emailService,encryptionService,userRespositoryService, cacheService);
userService.Register(email: "rony@mail.com", password: "12345Ciber");

