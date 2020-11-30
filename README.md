# project : RentCar

#사용한 프로젝트
C# 8.0
.Net Framework 4.8
EntityFramework 6.4
MSSQL Server 2019
-----------------------------------
DB

-서버 : kimpro
-파일명 : RentCar
-테이블명 규칙 : 첫글자대문자, 간결성유지.
-Rent(Main) ---연결---User, Car
-User (= Account) ---연결---Event
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
<<>>>
-Customer
-Manager
-Admin

---------------------------------------------------
#다이어그램
                              
                                       
                                



--------------------------------------------------------
#구현
구현 완성
-스키마 : 제3 정규화까지 완성함.


구현 미완성
-Event와 Search의 구현
-관리자 폼에서 매출현황차트와 엑셀 파일 저장
-지점 여러개 만들기
https://github.com/KimHuiEun/RentCar/issues/10#issue-752119211

----------------------------------------------------------
#오류

1.

오류: App.config에 MySQL과 연결 관계에 대한 문구를 넣지 않음.

해결방안 : <connectionStrings>
    <add name="RentCarEntities" connectionString="metadata=res://*/RentCar.csdl|res://*/RentCar.ssdl|res://*/RentCar.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=kimpro;initial catalog=_RentCar;user id=sa;password=3512;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
  
  
  
  
 2.
 
 오류 : 주 진입 프로젝트를 중단점으로 몇 개의 코드만 실행했을 때 생기는 디버깅 오류
 
 해결방안 : 디버깅을 할 때의 설정에 내 코드만 되어 있어 외부 코드 참조한 것이 디버깅이 되지 않아 생기는 오류라 설정에서 고쳤다.
 
 https://docs.microsoft.com/ko-kr/visualstudio/debugger/just-my-code?view=vs-2019 참조.


3.
오류 : text 파일 읽어들이는 과정에서 오류가 생김. System.Windows.Forms.MaskedTextBox., Text: aa님, 안녕하세요!

해결방안 : 입력된 텍스트를 읽어오는 것이 아니라 텍스트 파일 자체를 읽으려고 했기 때문에. 
     수정 후 
     -Text: aa님, 안녕하세요!

if(tbLoginId.Text != "admin" && tbLoginId.Text != "manager")
{
     if (user.LoginPw == tbLoginPw.Text)     
     {
           MessageBox.Show(tbLoginId.Text + "님, 안녕하세요!");     ----->원래소스 : textbox 이름인 tbLoginId 를 불러오는 것. 
           this.Close();
     }
     else
     MessageBox.Show("잘못된 비밀번호입니다.");
}


4. 
오류 : 데이터 엔터티 모델 수정 오류

해결방안 : RentCar.edmx에서 전부 삭제 했다가 데이터베이스 모델 업데이트 하기.


5.
오류 : 깃 허브 중복 소스 충돌 해결방안

해결방안 : 소스를 비교하면서 현재 파일을 선택하고 받아들이는 소스 부분부분을 복사 붙여넣기함.


6.
오류 : 메타데이터 파일 오류

해결방안 : Add.config에서 메타데이터에 관한 connectionString="metadata=res: 부분의 서버연결 확인하였음.
<connectionStrings>
    <add name="RentCarEntities" connectionString="metadata=res://*/RentCar.csdl|res://*/RentCar.ssdl|res://*/RentCar.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=kimpro;initial catalog=_RentCar;user id=sa;password=3512;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>


7.
오류 : 데이터베이스 저장하려고 DataGridView 사용하였으나 사용법을 모름.

해결방안 : 
private void CustomerManagement_Load(object sender, EventArgs e)
{
    this.userTableAdapter1.Fill(this._RentCarDataSet1.User);
    this.userTableAdapter.Fill(this._RentCarDataSet.User);
    Clear();
    PopulateDataGridView();
}

private void BtnSave_Click(object sender, EventArgs e)
{

    model.LoginId = TbUserId.Text.Trim();
    model.LoginPw = TbUserPassword.Text.Trim();
    model.Name = TbUserName.Text.Trim();
    model.PhoneNumber = MtbPhoneNumber.Text.Trim();
    model.License = MtbLicense.Text.Trim();
    model.IssueDate = DtIssueDate.CustomFormat.Trim();


    using (RentCarEntities db = new RentCarEntities())
    {
        db.Users.Add(model);
        db.SaveChanges();
    }
    Clear();
    PopulateDataGridView();
    MessageBox.Show("추가되었습니다.");

}
'''
void PopulateDataGridView()
{
    using(RentCarEntities db = new RentCarEntities())
    {
        DgvUser.DataSource = db.Users.ToList<User>();
    }
}
'''
