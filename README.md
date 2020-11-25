# RentCar

DB
-서버 : kimpro
-파일명 : RentCar
-테이블명 규칙 : 첫글자대문자, 간결성유지.
   -Rent(Main) ---연결---User, Car
   -User  (= Account)  ---연결---Event
   -Event
   -Car ---연결--- CarType, IsRent의 변수로 렌트중인지아닌지 구분(bit)
   -CarType
   -Admin ---연결--- User, Car
   -Search ---연결--- User, CarType

visual studio C#
-C:git
-솔루션이름 : CarRentalManagementSystem
-프로젝트 이름 : CarRent, CarRent.Data, CarRent.UnitTest
-CarRent의 폼.
  -Login
  -Account
  -Selection
  -Payment
  <<<Mypage>>>>
  -Customer
  -Manager
  -Admin
    
