CREATE DATABASE Blog
GO

USE Blog


CREATE TABLE BlogUsers
( 
  Id int primary key identity(1,1) not null,
  Name VARCHAR(64),
  Login VARCHAR(64),
  Password  VARCHAR(64),
  IsAdmin Bit not null
);

CREATE TABLE Articles 
( Id int primary key identity(1,1) not null,
  CreationDate DATETIME DEFAULT CURRENT_TIMESTAMP,
  UserId INT REFERENCES BlogUsers(Id) not null,
  Title varchar(255) NOT NULL,
  Content text NOT NULL,
  ShortContent varchar(500) 
);

CREATE TABLE Comments 
( Id int primary key identity(1,1) not null,
  CreationDate DATETIME,
  UserId INT REFERENCES BlogUsers(Id) not null,
  ArticleID INT REFERENCES Articles(Id) not null,
  CommentText text NOT NULL
);


INSERT INTO BlogUsers (Name, Login, Password, IsAdmin) VALUES
('Admin', 'admin',  '123456', 1),
('User', 'user',  '123456', 0),
('Spamer', 'spamer', '123456', 0);


INSERT INTO Articles (UserId, Title, Content, ShortContent) VALUES
(1, '1.Lorem ipsum dolor sit amet', 'Lorem ipsum dolor sit amet, et mel summo cetero maluisset, ut quo nonumy repudiare. At vim appareat reprimique, at antiopam efficiendi mea. Cetero aliquam eleifend ut eos, ea his ludus tation. Vis ne nemore perfecto efficiantur.

Option aliquid ea pri, duo id tota lorem efficiendi. Ea sea brute oporteat, ex invidunt consulatu sed. Vel cu affert dignissim. Sed ea odio velit delectus. Ut recusabo complectitur comprehensam ius, enim senserit duo ne.

Aliquid quaerendum ullamcorper in pri, ex sit solum invidunt. Has ad dicta latine. Qui velit concludaturque ea. Per ut postea facete oporteat. Mazim oblique singulis pro eu, modo audiam nec ne, quo ea scripta tractatos petentium. Est ullum scripta ei, per ex aliquid abhorreant deterruisset, ea diam elitr tibique his.

Ad quot salutatus ullamcorper eum. Quod reque pertinax no mel, ei liber fabellas definitiones mea. Ex feugiat adipisci eleifend mel, has scripta veritus te. Id eam denique quaestio, an mea stet sonet suscipiantur, ea usu quod clita iriure. At sit elitr euripidis, eos ex aeterno adipiscing percipitur, ex mea odio augue.',
'Short content, Short content,Short content,Short content,Short content,Short content,Short content,Short content,Short content'),
(1, '2.Lorem ipsum dolor sit amet', 'Lorem ipsum dolor sit amet, et mel summo cetero maluisset, ut quo nonumy repudiare. At vim appareat reprimique, at antiopam efficiendi mea. Cetero aliquam eleifend ut eos, ea his ludus tation. Vis ne nemore perfecto efficiantur.

Option aliquid ea pri, duo id tota lorem efficiendi. Ea sea brute oporteat, ex invidunt consulatu sed. Vel cu affert dignissim. Sed ea odio velit delectus. Ut recusabo complectitur comprehensam ius, enim senserit duo ne.

Aliquid quaerendum ullamcorper in pri, ex sit solum invidunt. Has ad dicta latine. Qui velit concludaturque ea. Per ut postea facete oporteat. Mazim oblique singulis pro eu, modo audiam nec ne, quo ea scripta tractatos petentium. Est ullum scripta ei, per ex aliquid abhorreant deterruisset, ea diam elitr tibique his.

Ad quot salutatus ullamcorper eum. Quod reque pertinax no mel, ei liber fabellas definitiones mea. Ex feugiat adipisci eleifend mel, has scripta veritus te. Id eam denique quaestio, an mea stet sonet suscipiantur, ea usu quod clita iriure. At sit elitr euripidis, eos ex aeterno adipiscing percipitur, ex mea odio augue.'
,
'Short content, Short content,Short content,Short content,Short content,Short content,Short content,Short content,Short content'),
(1, '3.Lorem ipsum dolor sit amet', 'Lorem ipsum dolor sit amet, et mel summo cetero maluisset, ut quo nonumy repudiare. At vim appareat reprimique, at antiopam efficiendi mea. Cetero aliquam eleifend ut eos, ea his ludus tation. Vis ne nemore perfecto efficiantur.

Option aliquid ea pri, duo id tota lorem efficiendi. Ea sea brute oporteat, ex invidunt consulatu sed. Vel cu affert dignissim. Sed ea odio velit delectus. Ut recusabo complectitur comprehensam ius, enim senserit duo ne.

Aliquid quaerendum ullamcorper in pri, ex sit solum invidunt. Has ad dicta latine. Qui velit concludaturque ea. Per ut postea facete oporteat. Mazim oblique singulis pro eu, modo audiam nec ne, quo ea scripta tractatos petentium. Est ullum scripta ei, per ex aliquid abhorreant deterruisset, ea diam elitr tibique his.

Ad quot salutatus ullamcorper eum. Quod reque pertinax no mel, ei liber fabellas definitiones mea. Ex feugiat adipisci eleifend mel, has scripta veritus te. Id eam denique quaestio, an mea stet sonet suscipiantur, ea usu quod clita iriure. At sit elitr euripidis, eos ex aeterno adipiscing percipitur, ex mea odio augue.',
'Short content, Short content,Short content,Short content,Short content,Short content,Short content,Short content,Short content');

INSERT INTO Comments(UserId, ArticleID, CommentText) VALUES
(3, 1, 'Мій перший спам!!!! :)))'),
(1, 1, 'Мій перший спам!!!! :)))Мій перший спам!!!! :)))Мій перший спам!!!! :)))'),
(2, 1, 'Мій перший спам!!!! :)))'),
(3, 1, 'Мій перший спам!!!! :)))'),
(3, 1, 'Мій перший спам!!!! :)))')


SELECT * FROM BlogUsers;

SELECT * FROM Articles;

--DELETE Comments
SELECT * FROM Comments;