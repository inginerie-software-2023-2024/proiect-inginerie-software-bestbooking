from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
import time

driver = webdriver.Chrome()

url = 'https://localhost:7154/Identity/Account/Login'

driver.get(url)

email_input = WebDriverWait(driver, 10).until(
    EC.presence_of_element_located((By.ID, 'Input_Email'))
)

email_input.send_keys('adela.danescu@yahoo.com')

password_input = WebDriverWait(driver, 10).until(
    EC.presence_of_element_located((By.ID, 'Input_Password'))
)

password_input.send_keys('Adela123!')

login_button = WebDriverWait(driver, 10).until(
    EC.element_to_be_clickable((By.XPATH, '//button[contains(text(), "Log in")]'))
)
login_button.click()

WebDriverWait(driver, 10).until(
    EC.presence_of_element_located((By.XPATH, '//article[@onclick="location.href=\'/Tari/Show/1\'"]'))
)

article_element_1 = driver.find_element(By.XPATH, '//article[@onclick="location.href=\'/Tari/Show/1\'"]')
article_element_1.click()

time.sleep(3)

article_element_2 = WebDriverWait(driver, 10).until(
    EC.presence_of_element_located((By.XPATH, '//article[@onclick="location.href=\'/Hoteluri/Show/6\'"]'))
)
article_element_2.click()

time.sleep(3)

button_element_1 = WebDriverWait(driver, 10).until(
    EC.presence_of_element_located((By.XPATH, '//a[@class="btn mr-2 custom-button" and @href="/Camere/Show/2"]'))
)
button_element_1.click()

time.sleep(3)

button_element_2 = WebDriverWait(driver, 10).until(
    EC.presence_of_element_located((By.XPATH, '//a[@class="btn btn-danger custom-button" and @href="/Rezervari/New/2"]'))
)
button_element_2.click()

time.sleep(3)

check_in_input = driver.find_element(By.ID, 'CheckIn')
driver.execute_script("arguments[0].value = '2024-02-10T00:00';", check_in_input)

check_in_input = driver.find_element(By.ID, 'CheckOut')
driver.execute_script("arguments[0].value = '2024-02-12T00:00';", check_in_input)

lista_clienti_input = driver.find_element(By.ID, 'ListaClienti')
lista_clienti_input.clear()
lista_clienti_input.send_keys('John Doe')

submit_button = driver.find_element(By.XPATH, '//input[@type="submit" and @value="Adaugă"]')
submit_button.click()
time.sleep(3)
driver.quit()