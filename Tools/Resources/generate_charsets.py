import re
from glob import glob

patterns = [
    '../../Assets/Nova/Fonts/Charset3500.txt',
    '../../Assets/Nova/Resources/Locales/*.json',
    '../../Assets/Examples/Colorless/Resources/Colorless/Scenarios/*.txt',
    '../../Assets/Resources/Locales/*/Colorless/Scenarios/*.txt',
]
out_filename = '../../Assets/Nova/Fonts/Charset.txt'
out_bold_filename = '../../Assets/Nova/Fonts/CharsetBold.txt'

with open(out_filename, 'r', encoding='utf-8') as f:
    old_text = f.read().strip('\n')
with open(out_bold_filename, 'r', encoding='utf-8') as f:
    old_text_bold = f.read().strip('\n')

text = ''
for pattern in patterns:
    for filename in glob(pattern):
        print(filename)
        with open(filename, 'r', encoding='utf-8') as f:
            text += f.read()

bolds = re.compile('<b>(.*?)</b>').findall(text)

text = ''.join(sorted(set(text))).strip('\n')
text_bold = ''.join(sorted(set(''.join(bolds)))).strip('\n')

if all(x in old_text for x in text):
    print('Need to rebuild font asset: NO')
else:
    print('Need to rebuild font asset: YES')
    with open(out_filename, 'w', encoding='utf-8', newline='\n') as f:
        f.write(text)

if all(x in old_text_bold for x in text_bold):
    print('Need to rebuild bold font asset: NO')
else:
    print('Need to rebuild bold font asset: YES')
    with open(out_bold_filename, 'w', encoding='utf-8', newline='\n') as f:
        f.write(text_bold)
