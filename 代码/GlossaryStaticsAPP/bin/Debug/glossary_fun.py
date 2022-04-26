# -*- coding: utf-8 -*-
""""glossary_fun.py"""


import pandas as pd
import matplotlib as mpl
import matplotlib.pyplot as plt
import time


mpl.rcParams['font.sans-serif'] = ['KaiTi']
mpl.rcParams['font.serif'] = ['KaiTi']

strip_glossary=['\u00A0','\u0020','\n','\t','\r','\f','\v',' ','\x20','\u3000']

"""计时装饰器"""
def Calculate_time(fun):
    def inner(*args,**kargs):
        start_time=time.time()
        ret=fun(*args,**kargs)
        end_time=time.time()
        print("用时：",end_time-start_time)
        return ret
    return inner


"""打开文件"""
# @Calculate_time
def GetTargetText(file_path,except_text=''):

    try:
        tfile=open(file_path,'r',encoding='utf-8')
    except FileNotFoundError as e:
        print("except:",e)
        print("\n找不到目标文件,文件丢失\n")
        
    else:
        target_text=tfile.read()
        if except_text != '':
            target_text=target_text.replace(except_text,'')
        tfile.close()
        
    return target_text

""""生成分词词汇表"""
# @Calculate_time
def GenerateGlossary(target_text, except_text='/'):
    words=''
    glo_dict={}
    
    for num, char in enumerate(target_text):
        i=0
        
        if char in strip_glossary:
            continue
        
        if char==except_text:
            if words in glo_dict:
                    glo_dict[words]+=1

            else:
                    glo_dict[words]=1
            words=''
        
        else:
            if target_text[num+i] in strip_glossary:
                i+=1
                continue
            else:
                words=words+target_text[num+i]
                i+=1
            
    glossary=pd.DataFrame.from_dict(glo_dict,orient='index')
    glossary.index.name='词汇'
    glossary.columns=['词频']

    return glossary



"""生成n-gram词汇表"""
# @Calculate_time
def GenerateGlossary_gram(target_text,gram=1):
    words=''
    glo_dict={}
    
    for num, char in enumerate(target_text):
        i=0
        
        if char in strip_glossary:
            continue
        
        while len(words)<gram and (num+i)<len(target_text):
                if target_text[num+i] in strip_glossary:
                    i+=1
                    continue
                else:
                    words=words+target_text[num+i]
                    i+=1
            
        if len(words)==gram:
            if words in glo_dict:
                    glo_dict[words]+=1

            else:
                    glo_dict[words]=1
            words=''
    glossary=pd.DataFrame.from_dict(glo_dict,orient='index')
    glossary.index.name='词汇'
    glossary.columns=['词频']

    return glossary


"""合并词表"""
# @Calculate_time
def MergeGlossary(glossary1,glossary2):
    return glossary1.add(glossary2,fill_value=0)


"""整理词汇表"""
# @Calculate_time
def SortGlossary(glossary):
    glossary=glossary.sort_values(by='词频',ascending=False,kind='quicksort')
    return glossary


"""希尔排序整理词表(淘汰)"""
def insert_sort(glossary,gap):
    for i in range(gap,len(glossary)):
        temp=glossary.iloc[i]
        j=i-gap
        
        while j>=0 and glossary.iloc[j].词频>temp.词频:
            glossary.iloc[j+gap]=glossary.iloc[j]
            j-=gap
        glossary.iloc[j+gap]=temp
    
# @Calculate_time  
def ShellSort(glossary):
    
    d=len(glossary)//2
    while d>0:
        insert_sort(glossary,d)
        d=d//2
    return glossary


"""获取常用词表"""
def GetPopularGlossary(glossary,limits=50):
    popular_glossary=glossary.head(limits)
    return popular_glossary


"""获取罕见词表"""
def GetRareGlossary(glossary,limits=50):
    rare_glossary=glossary.tail(limits)
    return rare_glossary


"""按词汇查找"""
# @Calculate_time
def SearchVocabulary(glossary,voc):
    target_glossary=glossary.loc[voc]
    return target_glossary


"""按数量范围查找"""
# @Calculate_time
def SearchNumber(glossary,low,high):
    target_glossary=glossary.iloc[:][glossary.词频>=low][glossary.词频<=high]
    return target_glossary

    
"""二分法查找"""
def BinarySearch(glossary,val,left,right):
    if left==right:
        return left
    mid=int((left+right)/2)
    if val<glossary.iloc[mid].词频:
        return BinarySearch(glossary,val,mid+1,right)
    elif val>glossary.iloc[mid].词频:
        return BinarySearch(glossary,val,left,mid)
    elif val==glossary.iloc[mid].词频:
        return mid


"""按数量范围查找，二分法"""
# @Calculate_time
def Bi_SearchNumber(glossary,low,high):
    left=0
    right=len(glossary)-1
    low_row=BinarySearch(glossary, low, left, right)
    while low_row<len(glossary):
        if glossary.iloc[low_row].词频<low:
            break
        low_row=low_row+1
    high_row=BinarySearch(glossary, high, left, right)
    while high_row>=0:
        if glossary.iloc[high_row].词频>high:
            break
        high_row=high_row-1
    target_glossary=glossary.iloc[high_row+1:low_row-1]
    return target_glossary
    
    
"""生成Excel"""
# @Calculate_time
def GenerateXlsx(glossary,xlsx_path,sheet_name):
    # print(4.1)
    writer=pd.ExcelWriter(xlsx_path)
    # print(4.2)
    glossary.to_excel(writer,sheet_name)
    # print(4.3)
    writer.save()
    
    
"""绘图"""
# @Calculate_time
def GeneratePicture(glossary,picture_path):
    # print(4.1)
    ax=glossary.plot.bar(alpha=0.75,rot=60,fontsize='small')
    # print(4.2)
    picture=ax.get_figure()
    # print(4.3)
    picture.savefig(picture_path,dpi=200)
    # print(4.4)
    
    
    
            
        
    