# -*- coding: utf-8 -*-
""""mainScript.py"""

import pandas as pd
import matplotlib as mpl
import matplotlib.pyplot as plt
import time
import glossary_fun as gl
import sys
import os

#调试
if __name__=="__main__":

        

    #读取文件，按特定分词符号分词
    if sys.argv[1]=='0':
        file_path=sys.argv[2]
        except_text=sys.argv[4]
        # print('打开文件')
        ttxt=gl.GetTargetText(file_path)
        
        #生成词表
        gram=sys.argv[3]#这里读进来没意义，但是为了保持格式统一方便判断先放进来
        if os.path.exists("tmp\\main_glossary"):
            main_glossary=pd.read_pickle('tmp\\main_glossary')
        else:
            main_glossary=pd.DataFrame({})
        # print('正在生成词表')
        tmp_glossary=gl.GenerateGlossary(ttxt, except_text)
        main_glossary=gl.MergeGlossary(main_glossary,tmp_glossary)
        #整理词表
        # print('正在整理词表')
        main_glossary=gl.SortGlossary(main_glossary)
        tmp_glossary=main_glossary
        main_glossary.to_pickle('tmp\\main_glossary')
        tmp_glossary.to_pickle('tmp\\tmp_glossary')
        print(main_glossary)
        
        
    #读取文件，按n-gram分词
    if sys.argv[1]=='1':
        file_path=sys.argv[2]
        # print('打开文件')
        except_text=sys.argv[4]
        ttxt=gl.GetTargetText(file_path, except_text)
        
        #生成词表
        gram=sys.argv[3]
        if os.path.exists("tmp\\main_glossary"):
            main_glossary=pd.read_pickle('tmp\\main_glossary')
        else:
            main_glossary=pd.DataFrame({})
        # print('正在生成词表')
        tmp_glossary=gl.GenerateGlossary_gram(ttxt,int(gram))
        main_glossary=gl.MergeGlossary(main_glossary,tmp_glossary)
        #整理词表
        # print('正在整理词表')
        main_glossary=gl.SortGlossary(main_glossary)
        tmp_glossary=main_glossary
        main_glossary.to_pickle('tmp\\main_glossary')
        tmp_glossary.to_pickle('tmp\\tmp_glossary')
        print(main_glossary)
    
    
    #获取高频词汇信息
    elif sys.argv[1]=='2':
        limits=int(sys.argv[2])
        main_glossary=pd.read_pickle('tmp\\main_glossary')
        tmp_glossary=pd.read_pickle('tmp\\tmp_glossary')
        tmp_glossary.to_pickle('tmp\\last_glossary')
        tmp_glossary=gl.GetPopularGlossary(tmp_glossary,limits)
        tmp_glossary.to_pickle('tmp\\tmp_glossary')
        print(tmp_glossary)
        
        
    #获取低频词汇信息
    elif sys.argv[1]=='3':
        limits=int(sys.argv[2])
        main_glossary=pd.read_pickle('tmp\\main_glossary')
        tmp_glossary=pd.read_pickle('tmp\\tmp_glossary')
        tmp_glossary.to_pickle('tmp\\last_glossary')
        tmp_glossary=gl.GetRareGlossary(tmp_glossary,limits)
        tmp_glossary.to_pickle('tmp\\tmp_glossary')
        print(tmp_glossary)
        
        
    #查找范围内词汇
    elif sys.argv[1]=='4':
        low=int(sys.argv[2])
        high=int(sys.argv[3])
        main_glossary=pd.read_pickle('tmp\\main_glossary')
        tmp_glossary=pd.read_pickle('tmp\\tmp_glossary')
        tmp_glossary.to_pickle('tmp\\last_glossary')
        tmp_glossary=gl.SearchNumber(main_glossary, low, high)
        tmp_glossary.to_pickle('tmp\\tmp_glossary')
        print(tmp_glossary)
    
    
    #查找词汇信息
    elif sys.argv[1]=='5':
        voc=sys.argv[2]
        main_glossary=pd.read_pickle('tmp\\main_glossary')
        tmp_glossary=pd.read_pickle('tmp\\tmp_glossary')
        try:
            fre=int(gl.SearchVocabulary(tmp_glossary, voc))
        except KeyError as e:
            print("\n找不到目标词汇，词频为0\n")
        else:
            tmp_glossary.to_pickle('tmp\\tmp_glossary')
            print("该词词频为：",fre)
        
        
    #生成excel文件
    elif sys.argv[1]=='6':
        # print(1)
        save_path=sys.argv[2]
        # print(2)
        gram=sys.argv[3]
        # print(3)
        main_glossary=pd.read_pickle('tmp\\main_glossary')
        tmp_glossary=pd.read_pickle('tmp\\tmp_glossary')
        # print(4)
        if int(gram)<4:
            gl.GenerateXlsx(tmp_glossary.head(1000000), save_path, gram+'元分词')
        else:
            gl.GenerateXlsx(tmp_glossary.head(1000000), save_path, '分词符号分词')
        # print(5)
            
        
    #生成绘图文件
    elif sys.argv[1]=='7':
        # print(1)
        save_path=sys.argv[2]
        # print(2)
        main_glossary=pd.read_pickle('tmp\\main_glossary')
        # print(3)
        tmp_glossary=pd.read_pickle('tmp\\tmp_glossary')
        # print(4)
        gl.GeneratePicture(gl.GetPopularGlossary(tmp_glossary), save_path)
        # print(5)
        gl.GeneratePicture(gl.GetPopularGlossary(tmp_glossary), "tmp\\tmp.png")
        # print(6)
        

    #恢复原表
    elif sys.argv[1]=='8':
        if os.path.exists("tmp\\main_glossary"):
            main_glossary=pd.read_pickle('tmp\\main_glossary')
            tmp_glossary=pd.read_pickle('tmp\\tmp_glossary')
            tmp_glossary.to_pickle('tmp\\last_glossary')
            tmp_glossary=main_glossary
            tmp_glossary.to_pickle('tmp\\tmp_glossary')
            print(tmp_glossary)
        else:
            print("原表为空，请读取文件！")
        
        
    #撤销
    elif sys.argv[1]=='9':
        if os.path.exists("tmp\\main_glossary"):
            tmp_glossary=pd.read_pickle('tmp\\tmp_glossary')
            last_glossary=tmp_glossary
            tmp_glossary=pd.read_pickle('tmp\\last_glossary')
            last_glossary.to_pickle('tmp\\last_glossary')
            tmp_glossary.to_pickle("tmp\\tmp_glossary")
            print(tmp_glossary)
        else:
            print("当前表为空！")
        
        
        
        
        