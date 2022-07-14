/*
 * Created by SharpDevelop.
 * User: David
 * Date: 13/7/2022
 * Time: 23:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace FingerPrintScanner
{
	/// <summary>
	/// Description of Api.
	/// </summary>
	public class Api
	{
		public static string ApiUrl = string.Empty;
		
		public HttpClient _httpClient = new HttpClient();
		
		public Api()
		{
		}
		
		
		public async void SendFingerPrintTokenAsync(string userId, string token)
		{
			try {
				var content = new MultipartFormDataContent();
				var _userId = new StringContent(userId);
				content.Add(_userId);
				
				var _token = new StringContent(token);
				content.Add(_token);
				
				_httpClient.PostAsync(ApiUrl, content);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error Message");
			}
		}
		
		public Task<string> GetFingerPrintTokenAsync(string userId)
		{
			try {
				var fingerPrintToken = _httpClient.GetStringAsync(ApiUrl + "/" + userId);
				return fingerPrintToken;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error Message");
				return Task.FromResult(string.Empty);
			}
		}
		
		public async void SendVerificationStatusAsync(string userId, bool verificationStatus)
		{
			try {
				var content = new MultipartFormDataContent();
				var _userId = new StringContent(userId);
				content.Add(_userId);
				
				var _verificationStatus = new StringContent(verificationStatus.ToString());
				content.Add(_verificationStatus);
				
				await _httpClient.PostAsync(ApiUrl, content);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error Message");
			}
		}
	}
}
