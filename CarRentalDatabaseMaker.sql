CREATE TABLE [dbo].[Colors] (
    [Id]   INT	IDENTITY(1,1)          NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Brands] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Cars] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT          NULL,
    [ColorId]     INT          NULL,
    [ModelYear]   INT          NOT NULL,
    [DailyPrice]  DECIMAL (18) NULL,
    [Description] TEXT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([Id])
);
CREATE TABLE [dbo].[Users](
[Id]          INT          IDENTITY (1, 1) NOT NULL,
[FirstName]   VARCHAR(50)  NOT NULL,
[LastName]   VARCHAR(50)  NOT NULL,
[Email] VARCHAR(255) NOT NULL,
[Password] VARCHAR(255) NOT NULL
);
CREATE TABLE [dbo].[Customers](
[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
[UserId] INT NOT NULL,
[CompanyName] VARCHAR(80) NULL,
FOREIGN KEY([CustomerId]) REFERENCES [dbo].[Users] ([Id])
);

CREATE TABLE [dbo].[Rentals](
[Id] INT NOT NULL,
[CarId] INT NOT NULL,
[CustomerId] INT NOT NULL FOREIGN KEY([CustomerId]) REFERENCES [dbo].[Customers] ([Id])
[RentDate] DATE NOT NULL,
[ReturnDate] DATE NULL,
);

insert into Colors (Name) values ('Violet');
insert into Colors (Name) values ('Indigo');
insert into Colors (Name) values ('Khaki');
insert into Colors (Name) values ('Indigo');
insert into Colors (Name) values ('Fuscia');
insert into Colors (Name) values ('Red');
insert into Colors (Name) values ('Pink');
insert into Colors (Name) values ('Orange');
insert into Colors (Name) values ('Puce');
insert into Colors (Name) values ('Yellow');
insert into Colors (Name) values ('Fuscia');
insert into Colors (Name) values ('Aquamarine');
insert into Colors (Name) values ('Orange');
insert into Colors (Name) values ('Pink');
insert into Colors (Name) values ('Fuscia');
insert into Colors (Name) values ('Indigo');
insert into Colors (Name) values ('Purple');
insert into Colors (Name) values ('Fuscia');
insert into Colors (Name) values ('Indigo');
insert into Colors (Name) values ('Blue');

insert into Brands (Id, Name) values (1, 'Jaguar');
insert into Brands (Id, Name) values (2, 'Toyota');
insert into Brands (Id, Name) values (3, 'Chevrolet');
insert into Brands (Id, Name) values (4, 'Ford');
insert into Brands (Id, Name) values (5, 'Lexus');
insert into Brands (Id, Name) values (6, 'Chrysler');
insert into Brands (Id, Name) values (7, 'Lamborghini');
insert into Brands (Id, Name) values (8, 'MINI');
insert into Brands (Id, Name) values (9, 'Hyundai');
insert into Brands (Id, Name) values (10, 'Dodge');
insert into Brands (Id, Name) values (11, 'Chevrolet');
insert into Brands (Id, Name) values (12, 'Volkswagen');
insert into Brands (Id, Name) values (13, 'Chevrolet');
insert into Brands (Id, Name) values (14, 'Acura');
insert into Brands (Id, Name) values (15, 'Mitsubishi');
insert into Brands (Id, Name) values (16, 'Mercedes-Benz');
insert into Brands (Id, Name) values (17, 'Infiniti');
insert into Brands (Id, Name) values (18, 'Ford');
insert into Brands (Id, Name) values (19, 'Subaru');
insert into Brands (Id, Name) values (20, 'Chevrolet');
insert into Brands (Id, Name) values (21, 'Buick');
insert into Brands (Id, Name) values (22, 'Honda');
insert into Brands (Id, Name) values (23, 'Saab');
insert into Brands (Id, Name) values (24, 'Subaru');
insert into Brands (Id, Name) values (25, 'Audi');
insert into Brands (Id, Name) values (26, 'Maserati');
insert into Brands (Id, Name) values (27, 'Pontiac');
insert into Brands (Id, Name) values (28, 'Toyota');
insert into Brands (Id, Name) values (29, 'Honda');
insert into Brands (Id, Name) values (30, 'Mitsubishi');
insert into Brands (Id, Name) values (31, 'Ford');
insert into Brands (Id, Name) values (32, 'Mazda');
insert into Brands (Id, Name) values (33, 'Mercury');
insert into Brands (Id, Name) values (34, 'Mitsubishi');
insert into Brands (Id, Name) values (35, 'Buick');
insert into Brands (Id, Name) values (36, 'Ford');
insert into Brands (Id, Name) values (37, 'Nissan');
insert into Brands (Id, Name) values (38, 'Chevrolet');
insert into Brands (Id, Name) values (39, 'Dodge');
insert into Brands (Id, Name) values (40, 'Pontiac');
insert into Brands (Id, Name) values (41, 'Mazda');
insert into Brands (Id, Name) values (42, 'Porsche');
insert into Brands (Id, Name) values (43, 'Bentley');
insert into Brands (Id, Name) values (44, 'Chrysler');
insert into Brands (Id, Name) values (45, 'Buick');
insert into Brands (Id, Name) values (46, 'Dodge');
insert into Brands (Id, Name) values (47, 'Suzuki');
insert into Brands (Id, Name) values (48, 'Land Rover');
insert into Brands (Id, Name) values (49, 'GMC');
insert into Brands (Id, Name) values (50, 'Nissan');
insert into Brands (Id, Name) values (51, 'Mercedes-Benz');
insert into Brands (Id, Name) values (52, 'Buick');
insert into Brands (Id, Name) values (53, 'Mercedes-Benz');
insert into Brands (Id, Name) values (54, 'Toyota');
insert into Brands (Id, Name) values (55, 'Volvo');
insert into Brands (Id, Name) values (56, 'Subaru');
insert into Brands (Id, Name) values (57, 'Chevrolet');
insert into Brands (Id, Name) values (58, 'Pontiac');
insert into Brands (Id, Name) values (59, 'Kia');
insert into Brands (Id, Name) values (60, 'Toyota');
insert into Brands (Id, Name) values (61, 'Suzuki');
insert into Brands (Id, Name) values (62, 'Nissan');
insert into Brands (Id, Name) values (63, 'GMC');
insert into Brands (Id, Name) values (64, 'Buick');
insert into Brands (Id, Name) values (65, 'Ford');
insert into Brands (Id, Name) values (66, 'Ford');
insert into Brands (Id, Name) values (67, 'GMC');
insert into Brands (Id, Name) values (68, 'Mazda');
insert into Brands (Id, Name) values (69, 'Infiniti');
insert into Brands (Id, Name) values (70, 'Pontiac');
insert into Brands (Id, Name) values (71, 'BMW');
insert into Brands (Id, Name) values (72, 'Ford');
insert into Brands (Id, Name) values (73, 'Honda');
insert into Brands (Id, Name) values (74, 'Audi');
insert into Brands (Id, Name) values (75, 'Honda');
insert into Brands (Id, Name) values (76, 'Isuzu');
insert into Brands (Id, Name) values (77, 'Acura');
insert into Brands (Id, Name) values (78, 'Pontiac');
insert into Brands (Id, Name) values (79, 'Saab');
insert into Brands (Id, Name) values (80, 'Mazda');
insert into Brands (Id, Name) values (81, 'Volkswagen');
insert into Brands (Id, Name) values (82, 'Audi');
insert into Brands (Id, Name) values (83, 'Ford');
insert into Brands (Id, Name) values (84, 'Cadillac');
insert into Brands (Id, Name) values (85, 'Dodge');
insert into Brands (Id, Name) values (86, 'Pontiac');
insert into Brands (Id, Name) values (87, 'Plymouth');
insert into Brands (Id, Name) values (88, 'Ford');
insert into Brands (Id, Name) values (89, 'Honda');
insert into Brands (Id, Name) values (90, 'Suzuki');
insert into Brands (Id, Name) values (91, 'Dodge');
insert into Brands (Id, Name) values (92, 'Mazda');
insert into Brands (Id, Name) values (93, 'Mazda');
insert into Brands (Id, Name) values (94, 'Ford');
insert into Brands (Id, Name) values (95, 'Dodge');
insert into Brands (Id, Name) values (96, 'MINI');
insert into Brands (Id, Name) values (97, 'Spyker');
insert into Brands (Id, Name) values (98, 'Pontiac');
insert into Brands (Id, Name) values (99, 'GMC');
insert into Brands (Id, Name) values (100, 'Mitsubishi');

insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (79, 18, 2019, 165.2042, 'Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (90, 9, 2018, 244.7212, 'Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (90, 7, 2015, 229.3494, 'Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (62, 3, 2018, 232.2913, 'Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (5, 19, 2015, 339.4436, 'Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (32, 16, 2016, 172.4808, 'Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (24, 12, 2021, 191.2149, 'Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (23, 13, 2015, 241.2584, 'Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (98, 3, 2017, 182.2856, 'Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi. Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (9, 14, 2017, 315.8366, 'Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (38, 1, 2019, 305.8393, 'Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (11, 8, 2015, 329.9228, 'Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (90, 16, 2021, 271.5403, 'Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (76, 4, 2019, 173.1575, 'Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (19, 19, 2021, 205.6446, 'Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (4, 12, 2021, 346.9592, 'Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (91, 19, 2015, 270.1228, 'Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (95, 17, 2019, 232.3929, 'Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (44, 10, 2020, 308.5749, 'Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (88, 3, 2017, 283.387, 'Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (58, 6, 2019, 217.1733, 'Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (38, 6, 2020, 302.265, 'Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (72, 6, 2018, 190.0014, 'Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (91, 15, 2016, 313.045, 'Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (77, 2, 2016, 312.0289, 'Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (6, 1, 2019, 196.4914, 'Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi. Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (49, 16, 2020, 155.7318, 'Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (70, 11, 2019, 304.9346, 'Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (78, 3, 2016, 295.0331, 'Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (5, 11, 2020, 305.2283, 'In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (26, 4, 2019, 288.1582, 'Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi. Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (49, 2, 2021, 318.2989, 'Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (89, 19, 2018, 288.7001, 'Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (45, 12, 2019, 318.8781, 'Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (70, 2, 2016, 262.9438, 'Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (49, 5, 2020, 275.8539, 'Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi. Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (10, 20, 2015, 198.9194, 'Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (65, 13, 2020, 279.0044, 'Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (5, 17, 2020, 306.3567, 'Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (14, 7, 2020, 188.6041, 'Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (27, 3, 2018, 195.5768, 'Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (28, 19, 2021, 159.8348, 'Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (76, 10, 2015, 169.2499, 'Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (27, 4, 2020, 225.9976, 'Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (85, 18, 2020, 173.919, 'Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (44, 8, 2020, 235.4693, 'Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (63, 3, 2021, 345.2814, 'Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi. Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (76, 19, 2020, 184.0649, 'Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (83, 11, 2019, 266.8751, 'Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.');
insert into Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) values (11, 13, 2016, 222.7212, 'Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius.');


